﻿using Aula128SobreposicaoPalavraBase.Entities;
using System;

namespace Aula128SobreposicaoPalavraBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine($"Account 1: {acc1.Balance}");
            Console.WriteLine($"Account 2: {acc2.Balance}");
        }
    }
}
