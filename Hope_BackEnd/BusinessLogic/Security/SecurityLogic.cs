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

        public void RegistroUsuario(UserDto user)
        {
            Persona PersonaToBD = _mapper.Map<Persona>(user.Persona);
            PersonaToBD = unitOfWork.Persona.InsertWithoutLog(PersonaToBD);
            User UsuarioToBD = _mapper.Map<User>(user);
            UsuarioToBD.PersonaId = PersonaToBD.Id;
            int RolUsuarioRegistro = unitOfWork.Rol.FirstOrDefault(x => x.Nombre == "Usuario").Id;
            UsuarioToBD.RolId = RolUsuarioRegistro;
            UsuarioToBD.Password = HashSaltPassword(UsuarioToBD.Password).Hash;
            //Falta guardar el salt en el objeto y en la DB

        }

        private HashSalt HashSaltPassword(string password)
        {
            string token = "";
            int PasswordLength;
            using (RandomNumberGenerator rng = new RNGCryptoServiceProvider())
            {
                byte[] tokenData = new byte[32];
                rng.GetBytes(tokenData);

                token = Convert.ToBase64String(tokenData);
            }
            PasswordLength = password.Length;

            int halflength = Int32.Parse(Math.Ceiling(decimal.Parse((PasswordLength / 2).ToString())).ToString());

            string PasswordSalt = password.Substring(0, halflength) + token + password.Substring(halflength);
            var hashAlgorithm = new Argon2i(Encoding.ASCII.GetBytes(PasswordSalt));
            hashAlgorithm.DegreeOfParallelism = 16;
            hashAlgorithm.MemorySize = 8192;
            hashAlgorithm.Iterations = 40;
            hashAlgorithm.Salt = Encoding.ASCII.GetBytes(token);

            string hash = ByteArrayToString(hashAlgorithm.GetBytes(128));

            return new HashSalt { Hash = hash, Salt = token };
        }

        private class HashSalt
        {
            public string Hash { get; set; }
            public string Salt { get; set; }
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
