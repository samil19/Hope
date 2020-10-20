using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models.Account
{
    public class PermisoRol : Base
    {
        public int RolId { get; set; }
        public int PermisoId { get; set; }
        public Rol Rol { get; set; }
        public Permiso Permiso { get; set; }
    }
}
