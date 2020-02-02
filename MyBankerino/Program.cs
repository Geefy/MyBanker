using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankerino
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new MyBankerAccount("Yeet");
            Card card = new Electron("Yeet", account);
            
            Console.WriteLine(card.ToString());
            Console.Read();
        }
    }
}
