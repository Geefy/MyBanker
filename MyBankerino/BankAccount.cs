using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankerino
{
    public abstract class BankAccount
    {
        private string accountOwnerName;
        protected string accountNumber;
        private string registryNumber;
        private double accountBalance = 0;
        public BankAccount(string accountOwner, string registryNumber)
        {
            this.accountOwnerName = accountOwner;
            this.registryNumber = registryNumber;
            GenerateAccountNumber();
        }

        protected string RegistryNumber { get => registryNumber; set => registryNumber = value; }
        protected string AccountOwnerName { get => accountOwnerName; set => accountOwnerName = value; }
        internal string AccountNumber { get => accountNumber;}

       
        internal void Withdraw(double amount)
        {
            //withdraws from account balance
            accountBalance -= amount;
        }

        internal void Deposit(double amount)
        {
            //deposits into bank account
            accountBalance += amount;
        }
        protected abstract void GenerateAccountNumber();

        public override string ToString()
        {
            return"Account owner: " + AccountOwnerName + "\nRegistry number: " + RegistryNumber + "\nAccount number: " + AccountNumber;
        }

    }
}
