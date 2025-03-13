using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion_1
{
    class Class1
    {
        private SqlConnection conexion = new SqlConnection("Data Source = KENNY\\DANIEL;Initial Catalog = Zoologico; Integrated Security = true");
        private DataSet ds;
        public DataTable MostrarDatos()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("select * from Zoo", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }
        public  DataTable Buscar(string Folio_Zoo)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select * from Zoo where Folio_Zoo like '%{0}%'", Folio_Zoo), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }
        public bool Insertar (string Folio_Zoo, string Nombre_Zoo,string Ciudad_Zoo, string Pais, string Tamaño, string Presupuesto)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("insert into Zoo values ({0}, '{1}', '{2}', '{3}', {4}, {5})", new string[] {
                Folio_Zoo, Nombre_Zoo, Ciudad_Zoo, Pais, Tamaño, Presupuesto
            }), conexion);

            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }
        public bool Eliminar(string Folio_Zoo)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("delete from Zoo where Folio_Zoo = '{0}'", Folio_Zoo), conexion);

            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }
        public bool Actualizar(string Folio_Zoo, string Nombre_Zoo, string Ciudad_Zoo, string Pais, string Tamaño, string Presupuesto)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format(
                "update Zoo set Nombre_Zoo = '{0}', Ciudad_Zoo = '{1}', Pais = '{2}', Tamaño = {3}, Presupuesto = {4} where Folio_Zoo = {5}"
                , new string[]
                {
                    Nombre_Zoo, Ciudad_Zoo, Pais, Tamaño, Presupuesto, Folio_Zoo
                }), conexion);

            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }
    }
}
