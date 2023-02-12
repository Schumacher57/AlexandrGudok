using System;
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



            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand("SELECT * FROM Debitors Order By Name", con);

                try
                {
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
                }
                catch
                {

                }

            }



            return allDebitors;
        }

        internal ArrayList GetAllCreditsForDebitor(string debitorID)
        {
            ArrayList allCredits = new ArrayList();
            string query = String.Format("SELECT * FROM Credits Where DebitorID='{0}' Order By OpenDate Desc", debitorID);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allCredits.Add(result);
                        }

                    }
                    else
                    {
                        return null;
                    }
                }
                catch
                {

                }

            }



            return allCredits;
        }

        internal object GetAllPaymentsForCredit(string creditorID)
        {

            ArrayList allPayments = new ArrayList();
            string query = String.Format("SELECT * FROM Payments Where CreditsID='{0}' Order By PaymentDate Desc", creditorID);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                    {
                        foreach (DbDataRecord result in dr)
                        {
                            allPayments.Add(result);
                        }

                    }
                    else
                    {
                        return new ArrayList();
                    }
                }
                catch
                {

                }

            }



            return allPayments;
        }
    }
}
