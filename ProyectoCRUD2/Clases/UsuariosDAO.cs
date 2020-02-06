using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
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
            String strclave = GetMD5(clave);

            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            ad.SelectCommand.Parameters.AddWithValue("@login", usuario);
            ad.SelectCommand.Parameters.AddWithValue("@clave", strclave);
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
        public static int guardar(Usuarios usuarios)
        {
            //definimos un objeo conexion 
            SqlConnection conn = new SqlConnection(cadenaConexion);

            string sql = "insert into usuarios(nombreCompleto, " +
                "login,clave,tipoUsuario) values(@nombreCompleto,@login,@clave,@tipoUsuario)";
            //definimos un comando 
            String strclave = GetMD5(usuarios.clave);//encrypta la clave
            SqlCommand comando = new SqlCommand(sql, conn);
            //vonfiguramos los parametros
            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.AddWithValue("@nombreCompleto", usuarios.nombreCompleto);
            comando.Parameters.AddWithValue("@login", usuarios.login);
            comando.Parameters.AddWithValue("@clave", strclave);
            comando.Parameters.AddWithValue("@tipoUsuario", usuarios.tipoUsuario);
            conn.Open();
            int x = comando.ExecuteNonQuery(); //ejecutamos el comando
            conn.Close();
            return x;
        }
        public static DataTable getDatos()
        {
            SqlConnection conn = new SqlConnection(cadenaConexion);
            string sql = "select idLogin,nombreCompleto,login,clave," +
                 "tipoUsuario from usuarios order by nombreCompleto";

            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            return dt;
        }
        public static DataTable getDatos(int idLogin)
        {
            SqlConnection conn = new SqlConnection(cadenaConexion);
            string sql = "select idLogin,nombreCompleto,login,clave," +
                 "tipoUsuario from usuarios where idLogin=@idLogin order by nombreCompleto";

            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            ad.SelectCommand.Parameters.AddWithValue("@idLogin", idLogin);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            return dt;
        }
        public static int delete(string idLogin)
        {
            SqlConnection conn = new SqlConnection(cadenaConexion);

            string sql = "delete from usuarios " +
                "where idLogin=@idLogin";

            //definimos un comando 
            SqlCommand comando = new SqlCommand(sql, conn);
            //vonfiguramos los parametros

            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.AddWithValue("@idLogin", idLogin);
            conn.Open();
            int x = comando.ExecuteNonQuery(); //ejecutamos el comando
            conn.Close();
            return x;
        }
        public static int actualizar(Usuarios usuarios)
        {

            //definimos un objeo conexion 
            SqlConnection conn = new SqlConnection(cadenaConexion);
            string sql = "UPDATE usuarios SET nombreCompleto=@nombreCompleto,login=@login,clave=@clave," +
                "tipoUsuario=@tipoUsuario WHERE idLogin=@idLogin ";
            //definimos un comando 
            String strclave = GetMD5(usuarios.clave);//encrypta la clave
            SqlCommand comando = new SqlCommand(sql, conn);
            //vonfiguramos los parametros
            conn.Open();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.AddWithValue("@idLogin", usuarios.idLogin);
            comando.Parameters.AddWithValue("@nombreCompleto", usuarios.nombreCompleto);
            comando.Parameters.AddWithValue("@login", usuarios.login);
            comando.Parameters.AddWithValue("@clave", strclave);
            comando.Parameters.AddWithValue("@tipoUsuario", usuarios.tipoUsuario);
            int x = comando.ExecuteNonQuery(); //ejecutamos el comando
            conn.Close();
            return x;
        }
        public static string GetMD5(string str)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }
}
