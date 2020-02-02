using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankerino
{
    class Electron : Card
    {
        static string[] prefix = new string[] { "4026", "417500","4508","4844", "4913","4917" };
        public Electron(string cardHolderName, BankAccount account) : base(cardHolderName, account, prefix, 16, true, 15, DateTime.Now.AddYears(5))
        {
        }
    }
}
