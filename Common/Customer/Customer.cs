using Common.Customer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DeroyalBank.Model
{
    public class Customer : BaseEntity
    {
        [JsonProperty]
        private string firstname { get; set; }
        [JsonProperty]
        private string lastname { get; set; }
        [JsonProperty]
        private string phoneNumber { get; set; }
        [JsonProperty]
        private string email { get; set; }
        [JsonProperty]
        private string accountNumber { get; set; }
        [JsonProperty]
        private AccountType accountType { get; set; }
        [JsonProperty]
        private string password { get; set; }
        [JsonProperty]
        private string note { get; set; }
        [JsonProperty]
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
        [JsonProperty]
       

        private int numberOfAccounts;
        
        public int NumberOfAccounts
        {
            get { return numberOfAccounts; }
            private set { numberOfAccounts = value; }
        }

        public Customer(string fname, string lname, string phone, string email, AccountType accountType, string password,  string accountNumber, double initialBalance = 0.0)
        {
            this.firstname = fname;
            this.lastname = lname;
            this.phoneNumber = phone;
            this.email = email;
            this.accountType = accountType;
            this.password = password;
            this.balance = initialBalance;
            this.note = note;
            this.accountNumber = accountNumber;
            numberOfAccounts = 1;
        }

        public string GetFirstname()
        {
            return firstname;
        }
        public void Deposit(double amount)
        {
            balance += amount;
        }
        public void Withdraw(double amount)
        {
            balance -= amount;
        }

        public string GetLastname()
        {
            return lastname;
        }

        public string PhoneNumber()
        {
            return phoneNumber;
        }
        public string Email()
        {
            return email;
        }
        public AccountType GetAccountType()
        {
            return accountType;
        }
        public void Balance()
        {
            Console.WriteLine("Current balance is " + balance);
        }
        public string GetPassword()
        {
            return password;
        }
        public string GetAccountNumber()
        {
            return accountNumber;
        }
    }
}