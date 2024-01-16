using System;
using System.Data.SqlClient;

namespace AzureDbConnect
{
    internal class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader reader;
        public static string constr = "Server=tcp:ashwitha1879serverdb.database.windows.net,1433;Initial Catalog=AzureBookStoreDataBasedb;Persist Security Info=False;User ID=ashwithans;Password=AshwithaSuvarna18*;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        static void Main(string[] args)
        {
            try
            {
                con = new SqlConnection(constr);
                con.Open();

                cmd = new SqlCommand("SELECT * FROM Author", con);
                reader = cmd.ExecuteReader();
                Console.WriteLine("Author Table:");
                while (reader.Read())
                {
                    Console.WriteLine($"Author ID: {reader["AuthorId"]}, Name: {reader["Name"]}");
                }

                cmd.CommandText = "SELECT * FROM Publisher";
                reader = cmd.ExecuteReader();
                Console.WriteLine("\nPublisher Table:");
                while (reader.Read())
                {
                    Console.WriteLine($"Publisher ID: {reader["PublisherId"]}, Name: {reader["PublisherName"]}, Address: {reader["Address"]}");
                }
                reader.Close(); 

                cmd.CommandText = "SELECT * FROM BookCategory";
                reader = cmd.ExecuteReader();
                Console.WriteLine("\nBookCategory Table:");
                while (reader.Read())
                {
                    Console.WriteLine($"Category ID: {reader["CategoryId"]}, Name: {reader["CategoryName"]}");
                }
                reader.Close(); 

                cmd.CommandText = "SELECT * FROM Book";
                reader = cmd.ExecuteReader();
                Console.WriteLine("\nBook Table:");
                while (reader.Read())
                {
                    Console.WriteLine($"Book ID: {reader["BookId"]}, Name: {reader["Name"]}, Price: {reader["Price"]}, Category ID: {reader["CategoryId"]}, Publisher ID: {reader["PublisherId"]}");
                }
                reader.Close(); 

                cmd.CommandText = "SELECT * FROM BookAuthor";
                reader = cmd.ExecuteReader();
                Console.WriteLine("\nBookAuthor Table:");
                while (reader.Read())
                {
                    Console.WriteLine($"Book ID: {reader["BookId"]}, Author ID: {reader["AuthorId"]}");
                }
                reader.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Server Error" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!" + ex.Message);
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
        }
    }
}
