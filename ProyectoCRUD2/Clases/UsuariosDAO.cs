using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace Academico
{
    public static class UsuariosDAO
    {
        private static string cadenaConexion = @"server=L-PCT-104\SQLEXPRESS2016; database= TI2019; user id=sa; password=Lab123456";
      
        public static bool validaUsuario(String usuario, string clave)
        {
            SqlConnection conn = new SqlConnection(cadenaConexion);
            string sql = "select idlogin,nombreCompleto " +
                 " from usuarios where login=@login and clave=@clave ";

            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            ad.SelectCommand.Parameters.AddWithValue("@login", usuario);
            ad.SelectCommand.Parameters.AddWithValue("@clave", clave);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            if (dt.Rows.Count>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
