using Aula134ClassesAbstratas.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Aula134ClassesAbstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            // CLASSE ABSTRATA Account - não pode ser instanciada.
            //Account acc1 = new Account();

            List<Account> list = new List<Account>();
            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            double sum = 0.0;

            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine($"Total balance: {sum.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine();

            foreach(Account acc in list)
            {
                // Chamadas polimórficas
                acc.Withdraw(10.0);

                Console.WriteLine($"Update balance for account {acc.Number}: " +
                    $"{acc.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }

        }
    }
}
