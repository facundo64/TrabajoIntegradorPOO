using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    public static class UsuarioMapper
    {
        public static Usuario Map(DataRow row)
        {
            Usuario usuario = new Usuario();

            usuario.Id = Convert.ToInt32(row["Id"]);
            usuario.NombreUsuario = row["NombreUsuario"].ToString();
            usuario.Email = row["Email"].ToString();
            usuario.Rol = row["Rol"].ToString();
            usuario.Activo = Convert.ToBoolean(row["Activo"]);

            if (row["PasswordHash"] != DBNull.Value)
            {
                usuario.PasswordHash = (byte[])row["PasswordHash"];
            }

            return usuario;
        }
    }
}