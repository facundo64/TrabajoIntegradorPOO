using BE;
using DAL.Mappers;
using INFRA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAOs
{
    public class UsuarioDAO
    {   
        private SQLHelper sqlHelper;

        public UsuarioDAO()
        {
            sqlHelper = new SQLHelper();
        }

        public Usuario ObtenerPorUsername(string nombreUsuario)
        {
            string consulta = "SELECT * FROM Usuario WHERE NombreUsuario = @user AND Activo = 1";

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@user", nombreUsuario)
            };

            DataTable tabla = sqlHelper.EjecutarConsulta(consulta, parametros);

            if (tabla.Rows.Count > 0)
            {
                return UsuarioMapper.Map(tabla.Rows[0]);
            }

            return null;
        }
    }
}