using System;
using System.Threading.Tasks;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq.Expressions;
using System.Data.Sql;
using System.Reflection.PortableExecutable;
using System.Xml.Linq;


namespace ConsoleApp18
{
     class connect
    {
        private static connect _Instance;
        private readonly SqlConnection conn = new SqlConnection(@"Data Source=JOO-PC\MSSQLSERVER2022;Initial Catalog=School;Integrated Security=True");
        private connect()
        {

        }
        public static connect GetInstance()
        {
            if (_Instance == null)
            {
                _Instance = new connect();
            }
            return _Instance;
        }
        public void GetConnection()
        {
            string query = @"select Id as id,FullName as Name , email as Email , BirthDate as BoD from employee;";
            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    string empname = dr["Name"].ToString();
                    string empgmail = dr["Email"].ToString();
                    string empdate = dr["BoD"].ToString();
                    Console.Write($"Name: {empname} and Gmail:{empgmail} and  BOD: {empdate} " + " ");

                    Console.WriteLine();
                }

            }

            else
            {
                Console.WriteLine("no data found");
            }

            dr.Close();
            conn.Close();
        }

    }



    class program
    {
       static void Main(string[] args)
        {
            
            connect c1 = connect.GetInstance();
            c1.GetConnection();
        }
    }
}
    
