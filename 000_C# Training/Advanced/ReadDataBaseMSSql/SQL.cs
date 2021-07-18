using System;
using System.Data;
using System.Data.SqlClient;

namespace SQLSpace
{
    class SQL
    {
        private SqlConnection sql;
        private SqlCommand cmd;
        private SqlDataReader reader;

        public SQL()
        {
            sql = new SqlConnection();
            sql.ConnectionString = @"server=WS17236894-LPA\SQLEXPRESS; database=SingleExchange; Integrated Security=True";
            sql.Open();
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sql;
        }

        public void NonQuery(string sqlCommand)
        {
            cmd.CommandText = sqlCommand;
            cmd.ExecuteNonQuery();            
        }

        public void Query(string sqlCommand)
        {
            cmd.CommandText = sqlCommand;
            reader = cmd.ExecuteReader();
            
            try
            {
                while (reader.Read())
                {
                    string firstName = (string)reader["firstName"];
                    Console.WriteLine(firstName);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                reader.Close();
            }
        }

        public void Close()
        {
            sql.Close();
        }
    }
}