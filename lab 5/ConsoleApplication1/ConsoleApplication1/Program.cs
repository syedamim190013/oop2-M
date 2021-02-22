using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
        class Fixed : Account
        {
            private int tenurYear;
            private int accountAge;

            public override int AccountAge
            {
                set { this.accountAge = value; }
            }

            public Fixed(string name, string id, int balance, int tenurYear)
                : base(name, id, balance)
            {
                this.tenurYear = tenurYear;
                this.accountAge = 0;
            }

            public override void Transfer(int amount, Account acc)
            {
                if (tenurYear <= accountAge && amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine("Successfull : New Balance : " + balance);
                }
                else
                {
                    Console.WriteLine("Failed");
                }
            }
            static void Main(string[] args)
            {

                Account a01 = new Savings("Syeda", "1234", 500000);
                a01.Transfer(8550, a01);

                Account a02 = new SpecialCurrent("Maherunnasha", "6432", 30050);
                a02.Transfer(20600, a02);

                Account a03 = new Fixed("Mim", "9976", 89076, 3);
                a03.AccountAge = 3;
                a03.Transfer(8000, a03);

                Account a04 = new OverDraft("Ritu", "2222", 56790, 9000);
                a04.Transfer(3000, a04);

                Console.ReadLine();

            }
        }
    }


   