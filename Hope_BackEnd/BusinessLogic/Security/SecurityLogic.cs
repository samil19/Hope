using AutoMapper;
using Common.DTOs.Account;
using DataAccess;
using DataAccess.EntityFramework;
using DataAccess.Models;
using DataAccess.Models.Account;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Konscious.Security.Cryptography;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Security
{
    public class SecurityLogic
    {
        public readonly HopeContext _context;
        public readonly UnitOfWork unitOfWork;
        public readonly IMapper _mapper;
        public SecurityLogic(HopeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            unitOfWork = new UnitOfWork(_context);
        }

        public LogIn InicioSesion(LogInUserDto incomingUser)
        {
            User user = _context.Usuarios.Include(t => t.Persona).FirstOrDefault(x => x.Email == incomingUser.Email);
            bool resultCheck = CheckPassword(user.Salt, user.Password, incomingUser.Password);
            if (resultCheck)
            {
                return new LogIn { User =  _mapper.Map<UserDto>(user), Result = true};
            }
            else
                return new LogIn { User = null, Result = false };
        }

        public void RegistroUsuario(UserDto user)
        {
            //Persona PersonaToBD = _mapper.Map<Persona>(user.Persona);
            //PersonaToBD = unitOfWork.Persona.InsertWithoutLog(PersonaToBD);
            User UsuarioToBD = _mapper.Map<User>(user);
            HashSalt hashSalt = HashSaltPassword(UsuarioToBD.Password);
            //UsuarioToBD.PersonaId = PersonaToBD.Id;
            int RolUsuarioRegistro = unitOfWork.Rol.FirstOrDefault(x => x.Nombre == "Usuario").Id;
            UsuarioToBD.RolId = RolUsuarioRegistro;
            UsuarioToBD.Password = hashSalt.Hash;
            UsuarioToBD.Salt = hashSalt.Salt;

            unitOfWork.Usuario.InsertWithoutLog(UsuarioToBD);
            unitOfWork.Complete();
        }

        private HashSalt HashSaltPassword(string password, string salt = "")
        {
            HashSalt hashSalt = InsertSalt(password, salt);
            string PasswordSalt = hashSalt.Hash; //Esto es password + salt (no hash)
            var hashAlgorithm = new Argon2i(Encoding.ASCII.GetBytes(PasswordSalt));
            hashAlgorithm.DegreeOfParallelism = 16;
            hashAlgorithm.MemorySize = 8192;
            hashAlgorithm.Iterations = 40;
            hashAlgorithm.Salt = Encoding.ASCII.GetBytes(hashSalt.Salt);

            string hash = ByteArrayToString(hashAlgorithm.GetBytes(128));

            return new HashSalt { Hash = hash, Salt = hashSalt.Salt };
        }

        private HashSalt InsertSalt(string password, string salt = "")
        {
            string Token = "";
            if (String.IsNullOrEmpty(salt))
            {
                using (RandomNumberGenerator Rng = new RNGCryptoServiceProvider())
                {
                    byte[] TokenData = new byte[32];
                    Rng.GetBytes(TokenData);

                    Token = Convert.ToBase64String(TokenData);
                }
            }
            else
            {
                Token = salt;
            }
            
            int PasswordLength = password.Length;
            int halflength = Int32.Parse(Math.Ceiling(decimal.Parse((PasswordLength / 2).ToString())).ToString());
            string PasswordSalt = password.Substring(0, halflength) + Token + password.Substring(halflength);
            return new HashSalt { Hash = PasswordSalt, Salt = Token };
        }

        public bool CheckPassword(string dbSalt, string dbPassword, string incomingPassword)
        {
            string passwordHashedSalted = dbPassword;
            string incomingPasswordHashedSalted = HashSaltPassword(incomingPassword, dbSalt).Hash; //Salted con salt de la DB
            return incomingPasswordHashedSalted == passwordHashedSalted;
        }

        private class HashSalt
        {
            public string Hash { get; set; }
            public string Salt { get; set; }
        }

        public class LogIn
        {
            public UserDto User { get; set; }
            public bool Result { get; set; }
        }

        private static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }
    }
}
