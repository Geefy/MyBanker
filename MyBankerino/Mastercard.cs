using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankerino
{
    class Mastercard : Card
    {
        static string[] prefix = new string[] { "51","52","53","54","55" };

        public Mastercard(string cardHolderName, BankAccount account) : base(cardHolderName, account, prefix, 16, true, 18, DateTime.Now.AddYears(5))
        {
        }
    }
}
