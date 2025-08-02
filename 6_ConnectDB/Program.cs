using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBootcamp4._6_ConnectDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //  string connection = "Server=DESKTOP-L71NKL9\\MSSQLSERVERR;Database=HR;Integrated Security=True;";

            string connection = "Server=DESKTOP-L71NKL9\\MSSQLSERVERR;Database=HR;User Id=sa;Password=123;";
           // string query = "select *  from Students";
            string query = "select *  from employees";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query,conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int  id = reader["employee_Id"] != DBNull.Value ? Convert.ToInt32(reader["employee_Id"]) : 0;
                    string name = Convert.ToString(reader["last_name"]);
                    double grade = Convert.ToDouble(reader["salary"]);
                    Console.WriteLine($"ID: {id}, Name: {name}, Salary: {grade}");
                }
                conn.Close();
            }
                Console.ReadKey();
        }




    }
}
