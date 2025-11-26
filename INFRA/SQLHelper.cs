using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFRA
{
    public class SQLHelper
    {
        // cadena de coneccion en una variable
        private string stringConexion = @"Data Source=.\SQLEXPRESS;Initial Catalog=ExamenLUG2025DB;Integrated Security=True;TrustServerCertificate=True;";

       
        public DataTable EjecutarConsulta(string consulta, SqlParameter[] parametros = null)
        {
         
            DataTable tabla = new DataTable();

      
            using (SqlConnection conexion = new SqlConnection(stringConexion))
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    
                    if (parametros != null)
                    {
                        comando.Parameters.AddRange(parametros);
                    }

                    conexion.Open();

                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(tabla);
                }
            }

     
            return tabla;
        }

        public int EjecutarAccion(string consulta, SqlParameter[] parametros = null)
        {
            int filasAfectadas = 0;

            using (SqlConnection conexion = new SqlConnection(stringConexion))
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    if (parametros != null)
                    {
                        comando.Parameters.AddRange(parametros);
                    }

                    conexion.Open();

                 
                    filasAfectadas = comando.ExecuteNonQuery();
                }
            }

            return filasAfectadas;
        }
    }
}