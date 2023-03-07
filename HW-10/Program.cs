// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Threading;

public class Program
{
    private static void Main()
    {
        // Встановлюємо максимальну та мінімальну кількість потоків у пулі
        ThreadPool.SetMinThreads(10, 10);
        ThreadPool.SetMaxThreads(50, 50);

        for (int i = 0; i < 1000; i++)
        {
            int iteration = i;

            // Створюємо потік в пулі
            ThreadPool.QueueUserWorkItem((state) =>
            {
                Console.WriteLine($"Iteration {iteration}, thread count: {ThreadPool.ThreadCount}");

                // Заблокувати потік на 10 секунд
                Thread.Sleep(10000);
            });
        }
        Thread.Sleep(1000000);
        Console.Read();
    }
}