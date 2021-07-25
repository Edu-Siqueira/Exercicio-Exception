using ExercicioException.Entities;
using ExercicioException.Entities.Exceptions;
using System;

namespace ExercicioException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");

                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial Balance: ");
                double balance = double.Parse(Console.ReadLine());

                Console.Write("Withdraw Limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Account acc = new(number, holder, balance, withdrawLimit);

                Console.WriteLine();

                Console.Write("Enter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine());
                acc.Withdraw(withdraw);

                Console.WriteLine($"New balance: {acc.Balance.ToString("F2")}");
            }
            catch(Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
