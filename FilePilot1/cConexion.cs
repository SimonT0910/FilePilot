using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilePilot1
{
    internal class cConexion
    {
        public SqlConnection Conexion = new SqlConnection(cadena);
        static private string cadena = @"Data Source=.;Initial Catalog=FilePilot;Integrated Security=True; Connection Timeout=30";


        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
