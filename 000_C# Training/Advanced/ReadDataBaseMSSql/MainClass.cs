using System;
using System.Data;
using System.Data.SqlClient;
using SQLSpace;
using FSO;
using System.IO;
using System.Text;

namespace SQLProject
{
    class MainClass
    {
        public static void Main()
        {
            SQL sql = new SQL();
            ReadTxt readTxt = new ReadTxt("data.txt");

            string strQuery;

            foreach (string[] line in readTxt)
            {
                Console.WriteLine(line.Length);
                strQuery = PrepareQuery(line);
                Console.WriteLine(strQuery);
                sql.NonQuery(strQuery);
                //sql.NonQuery("insert into members (id, firstname, lastname, age, narodowosc) values (3, 'Eric', 'Cantona', '50', 'FRA')");
            }
            
            
            // sql.Query("select firstname from members");
            // sql.Query("select lastname from members");

            sql.Close();
        }

        public static string PrepareQuery(string[] line)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("insert into members (id, firstname, lastname, age, narodowosc) values ");
            sb.Append("(");
            sb.Append(line[0]);
            sb.Append(",'");
            sb.Append(line[1]);
            sb.Append("','");
            sb.Append(line[2]);
            sb.Append("','");
            sb.Append(line[3]);
            sb.Append("','");
            sb.Append(line[4]);
            sb.Append("');");

            return sb.ToString();
        }
    }
}