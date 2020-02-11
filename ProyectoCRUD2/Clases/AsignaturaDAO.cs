using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academico
{
    class AsignaturaDAO
    {
        private static string cadenaConexion = @"server=A-SIS-050\SQLEXPRESS2016; database= TI2019; user id=sa; password=Lab123456";
        public static int guardar(Asignatura asignatura)
        {

            //definimos un objeo conexion 
            SqlConnection conn = new SqlConnection(cadenaConexion);

            string sql = "insert into asignaturas(codAsignatura,nombreAsignatura,nivel,creditos," +
                "carrera) values(@codAsignatura,@nombreAsignatura,@nivel,@creditos,@carrera)";
            //definimos un comando 
            SqlCommand comando = new SqlCommand(sql, conn);
            //vonfiguramos los parametros

            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.AddWithValue("@codAsignatura", asignatura.CodAsignatura);
            comando.Parameters.AddWithValue("@nombreAsignatura", asignatura.NombreAsignatura);
            comando.Parameters.AddWithValue("@nivel", asignatura.Nivel);
            comando.Parameters.AddWithValue("@creditos", asignatura.Creditos);
            comando.Parameters.AddWithValue("carrera", asignatura.Carrera);
            conn.Open();
            int x = comando.ExecuteNonQuery(); //ejecutamos el comando
            conn.Close();
            return x;
        }
        /// <summary>
        /// Devuelve todas las filas de la tabla
        /// </summary>
        /// <returns></returns>
        public static DataTable getDatos()
        {
            SqlConnection conn = new SqlConnection(cadenaConexion);
            string sql = "select codAsignatura,nombreAsignatura,nivel,creditos," +
                 "carrera from asignaturas order by nombreAsignatura";

            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            return dt;
        }
        public static DataTable getNombresCompletos()
        {
            SqlConnection conn = new SqlConnection(cadenaConexion);
            string sql = "select codAsignatura,upper(nombreAsignatura) as Asignatura " +
                 " from asignaturas order by nombreAsignatura";

            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            return dt;
        }
        /// <summary>
        /// Obtiene un estudiante por su numero de matricula
        /// </summary>
        /// <param name="codAsignatura"></param>
        /// <returns></returns>
        public static DataTable getDatos(String codAsignatura)
        {
            SqlConnection conn = new SqlConnection(cadenaConexion);
            string sql = "select codAsignatura,nombreAsignatura,nivel,creditos," +
                 "carrera from asignaturas " +
                 "where codAsignatura=@codAsignatura " +
                 "order by nombreAsignatura";

            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            ad.SelectCommand.Parameters.AddWithValue("@codAsignatura", codAsignatura);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            return dt;
        }
        public static int delete(String codAsignatura)
        {
            SqlConnection conn = new SqlConnection(cadenaConexion);

            string sql = "delete from asignaturas " +
                "where codAsignatura=@codAsignatura";

            //definimos un comando 
            SqlCommand comando = new SqlCommand(sql, conn);
            //vonfiguramos los parametros

            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.AddWithValue("@codAsignatura", codAsignatura);
            conn.Open();
            int x = comando.ExecuteNonQuery(); //ejecutamos el comando
            conn.Close();
            return x;
        }
        public static int actualizar(Asignatura asignatura)
        {

            //definimos un objeo conexion 
            SqlConnection conn = new SqlConnection(cadenaConexion);
            string sql = "UPDATE asignaturas SET nombreAsignatura=@nombreAsignatura,nivel=@nivel,creditos=@creditos," +
                "carrera=@carrera WHERE codAsignatura=@codAsignatura ";
            //definimos un comando 
            SqlCommand comando = new SqlCommand(sql, conn);
            //vonfiguramos los parametros
            conn.Open();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.AddWithValue("@codAsignatura", asignatura.CodAsignatura);
            comando.Parameters.AddWithValue("@nombreAsignatura", asignatura.NombreAsignatura);
            comando.Parameters.AddWithValue("@nivel", asignatura.Nivel);
            comando.Parameters.AddWithValue("@creditos", asignatura.Creditos);
            comando.Parameters.AddWithValue("@carrera", asignatura.Carrera);
            int x = comando.ExecuteNonQuery(); //ejecutamos el comando
            conn.Close();
            return x;
        }
    }
}
