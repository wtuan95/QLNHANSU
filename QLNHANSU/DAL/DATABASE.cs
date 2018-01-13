using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
namespace QLNHANSU.DAL
{
    class DATABASE
    {
        SqlConnection conn = new SqlConnection();
        public DATABASE()
        {
            // quen sua
            conn.ConnectionString = File.ReadAllText(Environment.CurrentDirectory + "/../../Files/chuoiketnoi.txt");
            conn.Open();
        }
        public DataTable  Execute(string query)
        {
            DataTable tbl = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(tbl);
            return tbl;
        }
        public int ExecuteNonQuery(string query)
        {
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(query, conn);
            return cmd.ExecuteNonQuery();
        }
        public object ExecuteScalar(string query)
        {
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(query, conn);
            return cmd.ExecuteScalar();
        }
        public bool CheckConnect()
        {
            return conn.State == ConnectionState.Open;
        }
        public void CloseConnect()
        {
            if(conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
