using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Text;
using System.Data.Linq;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace myprojet
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection cnx = new SqlConnection("Data Source = .\\SQLEXPRESS; Initial Catalog = ESI_COS; Integrated Security = True");
            cnx.Open();
            SqlCommand cmd = cnx.CreateCommand();
            cmd.CommandText = "SELECT * FROM employes;";
            SqlDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                for (int i = 0; i < rdr.FieldCount; i++)
                {
                    Console.WriteLine(rdr.GetValue(i));
                }
                Console.WriteLine();
            }
        }
    }
}
