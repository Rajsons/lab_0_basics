using System;
using System.IO;

namespace Lab0_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string userInput;
            int startNumber = -1;

            
            while (startNumber < 0)
            {
                Console.Write("Enter the lower number: ");
                userInput = Console.ReadLine();

                
                if (Int32.TryParse(userInput, out startNumber) && startNumber >= 0)
                {
                    Console.WriteLine($"The user typed the {userInput} number.");
                }
                else
                {
                    Console.WriteLine("Please enter a valid non-negative integer.");
                    startNumber = -1;
                }
            }

            int endNumber = startNumber;

            
            while (endNumber <= startNumber)
            {
                Console.Write("\nEnter a high number (greater than lower number): ");
                userInput = Console.ReadLine();

                
                if (Int32.TryParse(userInput, out endNumber) && endNumber > startNumber)
                {
                    Console.WriteLine($"The user typed the {userInput} number.");
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer greater than the start number.");
                    endNumber = startNumber; 
                }
            }

            
            var primeNumbers = new System.Collections.Generic.List<int>();

            
            for (int i = startNumber; i < endNumber; i++)
            {
                if (IsPrime(i))
                {
                    primeNumbers.Add(i);
                }
            }

            
            foreach (int prime in primeNumbers)
            {
                Console.WriteLine($"Prime: {prime}");
            }

            string filePath = @"D:\SAIT SEM 2 SD\OOP 2\Class_projects\lab_0_basics\lab_0_basics\numbers.txt";

            
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = primeNumbers.Count - 1; i >= 0; i--)
                {
                    writer.WriteLine(primeNumbers[i]);
                }
            }
        }

        
        static bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
