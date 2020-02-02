using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankerino
{
    class Visa : Card
    {
        static string[] prefix = new string[] { "4" };
        public Visa(string cardHolderName, BankAccount account) : base(cardHolderName, account, prefix, 16, true, 18, DateTime.Now.AddYears(5))
        {

        }

       
    }
}
