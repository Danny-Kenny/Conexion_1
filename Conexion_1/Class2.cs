using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion_1
{
    class Class2
    {
        private SqlConnection conexion = new SqlConnection("Data Source = KENNY\\DANIEL; Initial Catalog = Zoologico; Integrated Security = true");
        private DataSet Data;

        public DataTable MostrarD()
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand("select * from Especie", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            Data = new DataSet();
            adaptador.Fill(Data, "tabla");
            conexion.Close();
            return Data.Tables["tabla"];
        }

        public DataTable Buscar(string Nombre_C)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand(string.Format("select * from Especie where Nombre_C like '%{0}%'", Nombre_C), conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            Data = new DataSet();
            adaptador.Fill(Data, "tabla");
            conexion.Close();
            return Data.Tables["tabla"];
        }

        public bool Insertar(string Nombre_C, string Nombre_B, string Familia, string Peligro_E)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand(string.Format("insert into Especie values ('{0}', '{1}', '{2}', '{3}')", Nombre_C, Nombre_B, Familia, Peligro_E), conexion);

            int afectadas = comando.ExecuteNonQuery();
            conexion.Close();
            return afectadas > 0;
        }

        public bool Eliminar(string Nombre_C)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand(string.Format("delete from Especie where Nombre_C = '{0}'", Nombre_C), conexion);
            
            int afectadas = comando.ExecuteNonQuery();
            conexion.Close();
            if (afectadas > 0) return true;
            else return false;
        }

        public bool Actualizar(string Nombre_C, string Nombre_B, string Familia, string Peligro_E)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand(string.Format("update Especie set Nombre_B = '{1}', Familia = '{2}', Peligro_E = '{3}' where Nombre_C = '{0}'", Nombre_C, Nombre_B, Familia, Peligro_E), conexion);

            int afectadas = comando.ExecuteNonQuery();
            conexion.Close();
            return afectadas > 0;
        }
    }
}
