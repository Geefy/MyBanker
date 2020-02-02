using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankerino
{
    class Maestro : Card
    {
        static string[] prefix = new string[] { "5018", "5020", "5038", "5893", "6304", "6759", "6761", "6762", "6763" };

        public Maestro(string cardHolderName, BankAccount account) : base(cardHolderName, account, prefix, 19, true, 18, DateTime.Now.AddMonths(60))
        {
        }
    }
}
