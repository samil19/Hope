using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IBarbaRepository Barba {get;}
ICabelloRepository Cabello {get;}
IDenunciaRepository Denuncia {get;}
IDiccionarioRepository Diccionario {get;}
IDiscapacidadRepository Discapacidad {get;}
IInformacionBasicaRepository InformacionBasica {get;}
IInformacionPoliciaRepository InformacionPolicia {get;}
IPersonaDenuncianteRepository PersonaDenunciante {get;}
IPersonaRepository Persona {get;}
IRopaRepository Ropa {get;}
ITatuajeRepository Tatuaje {get;}
ITelefonoRepository Telefono {get;}
        int Complete();
    }
}
