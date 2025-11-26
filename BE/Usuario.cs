using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public byte[] PasswordHash { get; set; } // contraseña para el hash
        public string Email { get; set; }
        public string Rol { get; set; }
        public DateTime FechaAlta { get; set; }
        public bool Activo { get; set; }
    }
}
