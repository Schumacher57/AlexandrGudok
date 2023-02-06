using System.Collections;
using System.Data.Common;
using System.Data.SqlClient;


namespace BankWinForms
{
    class DAL
    {

        /// <summary>
        /// Строка соединения
        /// </summary>
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Projects\MyTest\C#\TestProjects\Learn\ADO.NET\AlexandrGudok(example)\DB\Bank.mdf;Integrated Security=True;Connect Timeout=30";

        public ArrayList GetAllDebitors()
        {
            ArrayList allDebitors = new ArrayList();
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand com = new SqlCommand("SELECT * FROM Debitors", con);

            con.Open();

            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                foreach (DbDataRecord result in dr)
                {
                    allDebitors.Add(result);
                }
            }
            else
            {
                return null;
            }
            con.Close();

            return allDebitors;
        }
    }
}
