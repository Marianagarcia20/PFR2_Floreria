using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Npgsql;
using System.Data;

namespace PFR2_Floreria
{
    internal class Conexionn
    {
        public static NpgsqlConnection  conexionn = new NpgsqlConnection("Server = 127.0.0.1; Port=5432;Database=Floreria20;User Id = postgres; Password=Salmon@190;");
        public static DataTable Query (string query)
        {
            conexionn.Open();
            DataTable datos = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query,conexionn);
            da.Fill(datos);
            conexionn.Close();
            return datos;

        }

    }
}
