using System;
using System.Collections.Generic;
using System.Text;

namespace Purse
{
    class Account_Balanse
    {
        public string account_name;
        public int starting_balanse;
        public Account_Balanse(string account_name, int starting_balanse) 
        {
            this.account_name = account_name; 
            this.starting_balanse = starting_balanse; 
        }

        public int current_balanse;

        public int withdraw()
        {

            Console.WriteLine("Введите сумму снятия ");
            int sum1 = int.Parse(Console.ReadLine());
            current_balanse = starting_balanse-sum1;
            Console.WriteLine("Баланс после снятия " + current_balanse);
            return current_balanse;
        }

        public int deposit(int current_balanse)
        {
            Console.WriteLine("Введите сумму зачисления ");
            int sum2 = int.Parse(Console.ReadLine());
            current_balanse = current_balanse + sum2;
            Console.WriteLine("Баланс после зачисления " + current_balanse);
            return current_balanse;

        }



    }
}
