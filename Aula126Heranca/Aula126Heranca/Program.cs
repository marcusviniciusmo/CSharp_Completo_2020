using Aula126Heranca.Entities;
using System;

namespace Aula126Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bAcc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // UPCASTING - Conversão da subclasse para a superclasse.

            Account acc1 = bAcc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            // DOWNCASTING - Conversão da superclasse para a subclasse.

            // acc2 foi instanciado com BusinessAccount, só que está em uma variável do tipo Account.
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);
            // acc2.Loan(100.0);

            // O compilador não gera erro, porém há em tempo de execução, não sendo possível converter SavingsAccount para BusinessAccount
            // BusinessAccount acc5 = (BusinessAccount)acc3;

            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }

            // FORMAS DE FAZER CASTING
            Console.WriteLine();
            Console.WriteLine("FORMAS DE FAZER CASTING:");
            Console.WriteLine();
            Console.WriteLine("SavingsAccount acc5 = (SavingsAccount)acc3;");
            SavingsAccount acc6 = (SavingsAccount)acc3;
            Console.WriteLine("BusinessAccount acc7 = acc2 as BusinessAccount;");
            BusinessAccount acc7 = acc2 as BusinessAccount;
        }
    }
}
