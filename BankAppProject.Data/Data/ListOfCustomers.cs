using DeroyalBank.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace DeroyalBank.Data
{
    public class ListOfCustomers
    {
        public string Email { get; private set; }
        public static Dictionary<string, Customer> customerList = new Dictionary<string, Customer>();
        private static readonly HashSet<string> usedEmails = new HashSet<string>();
        public static string filepath = "Customer.json";
        public static void AddCustomer(string accountNo, Customer customer)
        {
            customerList.Add(accountNo, customer);
            usedEmails.Add(customer.Email());
            SaveCustomerToFileAsync();


        }
        public static async Task SaveCustomerToFileAsync()
        {
            try
            {
                string json = JsonConvert.SerializeObject(customerList, Formatting.Indented);
                await Task.Run(()=>File.WriteAllText(filepath, json));
                Console.WriteLine("Customer data saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while saving customer data: " + ex.Message);
            }
        }
        public static async Task LoadCustomerFromFileAsync()
        {
            try
            {
                string jsonFile = await Task.Run(()=>File.ReadAllText(filepath));
                var customeList = JsonConvert.DeserializeObject<Dictionary<string, Customer>>(jsonFile);

                if (customeList != null)
                {
                    customerList = customeList;
                }
                if (customeList.Count > 0)
                {
                    Console.WriteLine("Customer Data loaded successfully");
                }
                else
                {
                    Console.WriteLine("No Custromer Data found in then file");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some errors occured: " + ex.Message);
            }
        }

        public static bool IsEmailUsed(string email)
        {
            return usedEmails.Contains(email);
        }
    }

   
}
