using System;
using System.Data.SqlClient;

namespace CSharpExceptionsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void Payment(int amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentException("Payments cannot be zero or less");
            }
        }

        public static void UpdateUser()
        {
            try
            {
                UpdateUserData();
            }
            catch(SqlException ex)
            {
                Log.AlertEveryone(ex);
                throw;
            }
            catch(Exception ex)
            {
                Log.Error(ex);
                throw;
            }
            finally
            {
                DisposeOfDatabaseConnection();
            }
        }

        public static void UpdateUserData()
        {

        }

        public static void DisposeOfDatabaseConnection()
        {

        }
    }
}
