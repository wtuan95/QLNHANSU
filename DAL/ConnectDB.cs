using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
namespace DAL
{
    public class ConnectDB
    {
        SqlConnection conn = new SqlConnection();
        public ConnectDB()
        {

            conn.ConnectionString = File.ReadAllText(Environment.CurrentDirectory + "/../../Files/chuoiketnoi.txt");
            conn.Open();
        }
        public DataTable Execute(string query)
        {
            try
            {
                DataTable tbl = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(tbl);
                return tbl;
            }
            catch(SqlException sqlException)
            {
                throw new Exception(sqlException.Message);
            }
            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        public int ExecuteNonQuery(string cmdText)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlException)
            {
                throw new Exception(sqlException.Message);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        public int ExecuteStoreProcedure(string nameSP, List<SqlParameter> paramsSP)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nameSP;
                cmd.Connection = conn;
                cmd.Parameters.AddRange(paramsSP.ToArray());
                
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlException)
            {
                throw new Exception(sqlException.Message);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        public object ExecuteScalar(string query)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteScalar();
            }
            catch (SqlException sqlException)
            {
                throw new Exception(sqlException.Message);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        public bool CheckConnect()
        {
            return conn.State == ConnectionState.Open;
        }
        public void CloseConnect()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
