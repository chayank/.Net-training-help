using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BankAccount
    {
        public static int count=1;

        private int id,accountBalance;

        public  BankAccount(int amount)
        {
            this.id = count + 1;
            int d = (int)System.DateTime.Now.DayOfWeek;
            if (d == 2) this.accountBalance = 1000;
            else if (d == 6 || d == 0) this.accountBalance = 500;
            else this.accountBalance = 0;

            if (amount > 0) this.accountBalance += amount;
        }

        public void deposit(int amount)
        {
            Console.WriteLine("trying to deposit-{0}",amount);
            System.Threading.Thread.Sleep(3000);
            int d = (int)System.DateTime.Now.DayOfWeek;
            int hr= (int)System.DateTime.Now.Hour;
            if (amount <= 50000)
            {
                if (d != 6 || d != 0)
                {
                    if ((hr >= 10 && hr <= 14) || (hr >= 16 && hr <= 18))
                    {
                        this.accountBalance += amount - 1;
                        Console.WriteLine(" deposited-{0} and balance - {1}", amount,this.accountBalance);
                    }
                    else
                    {
                        Console.WriteLine("deposit faild as it is done outside workinghours");
                    }

                }
                else
                {
                    Console.WriteLine("deposit failed as it is done a weekend");
                }

            }
            else
            {
                Console.WriteLine("deposit failed as amount is more than 50k");
            }
           


        }
        
        public void fundtransfer(BankAccount c2,int amount)
        {
            if (this.accountBalance > amount)
            {

                int d = (int)System.DateTime.Now.DayOfWeek;
                int hr = (int)System.DateTime.Now.Hour;
                if (amount <= 50000)
                {
                    if (d != 6 || d != 0)
                    {
                        if ((hr >= 10 && hr <= 14) || (hr >= 16 && hr <= 18))
                        {
                            c2.accountBalance += amount;
                            this.accountBalance -= amount;

                            Console.WriteLine(" fund transfered-{0} and balance - {1}", amount, this.accountBalance);
                        }
                        else
                        {
                            Console.WriteLine("fund transfer faild as it is done outside workinghours");
                        }

                    }
                    else
                    {
                        Console.WriteLine("fund transfer failed as it is done a weekend");
                    }

                }
                else
                {
                    Console.WriteLine("fund transfer failed as amount is more than 50k");
                }


            }
            else
            {
                Console.WriteLine("insufficent funds in your account");
            }
        }
    }
}
