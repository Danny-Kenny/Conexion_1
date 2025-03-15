using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion_1
{
    class Class3
    {
        private SqlConnection conexion = new SqlConnection("Data Source = KENNY\\DANIEL; Initial Catalog = Zoologico; Integrated Security = true");
        private DataSet Almacen;

        public DataTable Aparecer()
        {
            conexion.Open();
            SqlCommand comdan = new SqlCommand("select * from Zoo_Animal", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(comdan);
            Almacen = new DataSet();
            adapter.Fill(Almacen, "tabla");
            conexion.Close();
            return Almacen.Tables["tabla"];
        }

        public DataTable Buscar(string Id_Animal)
        {
            conexion.Open();
            SqlCommand comdan = new SqlCommand(string.Format("select * from Zoo_Animal where Id_Animal like '%{0}%'", Id_Animal), conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(comdan);
            Almacen = new DataSet();
            adapter.Fill(Almacen, "tabla");
            conexion.Close();
            return Almacen.Tables["tabla"];
        }

        public bool Actualizar(string Id_Animal, string Especie, string Sexo, string Fecha_Nac, string Origen_P, string Origen_C, string Folio_Zoo, string Nombre_C)
        {
            conexion.Open();
            SqlCommand comdan = new SqlCommand(string.Format("update Zoo_Animal set Especie = '{1}', Sexo = '{2}', Fecha_Nac = '{3}', Origen_P = '{4}', Origen_C = '{5}', Folio_Zoo = {6}, Nombre_C = '{7}' where Id_Animal = '{0}'",
                                               Id_Animal,
                                               Especie,
                                               Sexo,
                                               Fecha_Nac,
                                               Origen_P,
                                               Origen_C,
                                               Folio_Zoo,
                                               Nombre_C), conexion);

            int afectadas = comdan.ExecuteNonQuery();
            conexion.Close();
            if (afectadas > 0) return true;
            else return false;
        }

        public bool Insertar(string Id_Animal, string Especie, string Sexo, string Fecha_Nac, string Origen_P, string Origen_C, string Folio_Zoo, string Nombre_C)
        {
            conexion.Open();
            SqlCommand comdan = new SqlCommand(string.Format("insert into Zoo_Animal values ({0}, '{1}', '{2}', '{3}', '{4}', '{5}', {6}, '{7}')",
                Id_Animal, Especie, Sexo, Fecha_Nac, Origen_P, Origen_C, Folio_Zoo, Nombre_C), conexion);

            int afectadas = comdan.ExecuteNonQuery();
            conexion.Close();
            if (afectadas > 0) return true;
            else return false;
        }

        public bool Eliminar(string Id_Animal)
        {
            conexion.Open();
            SqlCommand comdan = new SqlCommand(string.Format("delete from Zoo_Animal where Id_Animal = '{0}'", Id_Animal), conexion);
            int afectadas = comdan.ExecuteNonQuery();
            conexion.Close();
            if (afectadas > 0) return true;
            else return false;
        }
    }
}
