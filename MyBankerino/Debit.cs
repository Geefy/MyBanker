using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankerino
{
    class Debit : Card
    {
        static string[] prefix = new string[] { "2400" };
        public Debit(string cardHolderName, BankAccount account) : base(cardHolderName, account, prefix, 16, false, 0, DateTime.Now.AddYears(100))
        {
        }
    }
}
