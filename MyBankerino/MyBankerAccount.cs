using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankerino
{
    class MyBankerAccount : BankAccount
    {
        public MyBankerAccount(string accountOwner) : base(accountOwner, "3520")
        {
        }

        //Generates an account number based on registry number and 10 random numbers
        protected override void GenerateAccountNumber()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);

            this.accountNumber = this.RegistryNumber;
            for (int i = 0; i < 10; i++)
            {
                this.accountNumber += rnd.Next(0, 9);
            }
        }
    }
}
