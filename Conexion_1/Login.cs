using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conexion_1
{
    internal class Login
    {
        SqlConnection conexion = new SqlConnection("Data Source = KENNY\\DANIEL;Initial Catalog = Altas; Integrated Security = true");
        
        public bool login(string ID_Usuario, string Passwoord)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand(string.Format("select * from Usuarios where ID_Usuario = '{0}' and Passwoord = '{1}'", ID_Usuario, Passwoord), conexion);
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                conexion.Close();
                return true;
            }
            else
            {
                conexion.Close();
                return false;
            }
        }

        public bool Registrar(string ID_Usuario, string Nombre, string Email, string Passwoord, string Nombre_Rol)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand(string.Format("insert into Usuarios values ({0}, '{1}', '{2}', '{3}', '{4}')", ID_Usuario, Nombre, Email, Passwoord, Nombre_Rol), conexion);
            int i = comando.ExecuteNonQuery();
            conexion.Close();
            if (i > 0) return true;
            else return false;
        }

    }
}
