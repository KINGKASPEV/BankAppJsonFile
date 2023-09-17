using DeroyalBank.Core;
using DeroyalBank.Data;

namespace DeroyalBankUI
{
    public class Program
    {
        public static async Task LoadCustomerAsync()
        {
            if (File.Exists(ListOfCustomers.filepath))
            {
                await ListOfCustomers.LoadCustomerFromFileAsync();
            }
        }
        static void Main(string[] args)
        {
            LoadCustomerAsync();
            Welcome.WelcomeCustomer();
            Console.ReadLine();
        }
    }
}