using System;
using System.Data.SqlClient;

namespace ConsoleADO
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Projects\MyTest\C#\TestProjects\Learn\ADO.NET\Drafts\ConsoleADO\bin\Debug\Resources\ForTraining.mdf;Integrated Security=True;Connect Timeout=30";




            SqlConnection connection = new SqlConnection(connectionString);
            string sqlExpression = "SELECT model, speed FROM Laptop";
            

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression,connection);
                SqlDataReader reader = command.ExecuteReader();
                Console.WriteLine($"{reader.GetName(0)}:\t {reader.GetName(1)}:");
                while (reader.Read())
                {
                    string model = reader.GetString(0);
                    double speed = double.Parse(reader.GetValue(1).ToString());
                    Console.WriteLine($"{model}\t {speed/10}x");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
                Console.WriteLine("Подключение закрыто");
            }

            Console.WriteLine("End work!");
            Console.ReadKey();
        }
    }
}
