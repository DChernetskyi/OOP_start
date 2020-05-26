using System;

namespace Interface2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВВедите текущий баланс");
            int x = int.Parse(Console.ReadLine());
            Account_Balanse account_Balanse = new Account_Balanse("Dima", x);
            var q = account_Balanse.withdraw();
            account_Balanse.deposit(q);


            Console.ReadLine();


        }
    }
}
