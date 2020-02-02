using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankerino
{
    public abstract class Card
    {
        private int cardLength;
        private string cardNumber;
        private string cardHoldersName;
        public string expireDate;
        private string[] cardPrefix;
        private bool international;
        private byte ageRequirement;
        private BankAccount bankAccount;

        public Card(string cardHolderName, BankAccount account, string[] prefix, int cardLength, bool international, byte ageReq, DateTime expireDate)
        {
            this.cardHoldersName = cardHolderName;
            this.bankAccount = account;
            this.CardPrefix = prefix;
            this.cardLength = cardLength;
            this.international = international;
            this.ageRequirement = ageReq;
            this.expireDate = expireDate.ToString();
            GenerateCardNumber();
        }

        public string CardHoldersName { get => cardHoldersName; }
        public string CardNumber { get => cardNumber; }
        protected string[] CardPrefix { get => cardPrefix; set => cardPrefix = value; }


        //Generates a card number with random numbers + a random card prefix
        protected virtual void GenerateCardNumber()
        {
            Random rng = new Random(DateTime.Now.Millisecond);

            this.cardNumber = CardPrefix[rng.Next(0, CardPrefix.Length)];

            while (CardNumber.Length < cardLength)
            {
                this.cardNumber += rng.Next(0, 9);
            }
        }

        public void Charge(double amount)
        {
            //withdraws from this cards bank account
            this.bankAccount.Withdraw(amount);
        }



        public override string ToString()
        {
            return "Card Number: " + CardNumber + "\nCard holder name: " + cardHoldersName + "\nAccount Number: " + bankAccount.AccountNumber;
        }
    }
}
