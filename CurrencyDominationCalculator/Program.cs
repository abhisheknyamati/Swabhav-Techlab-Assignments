using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrenctCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Amount amount = new Amount();

            try
            {
                Console.WriteLine("Enter the amount (must be multiple of 100 and <= 50000): ");
                int userInput = int.Parse(Console.ReadLine());

                amount.CalculateDenominations(userInput);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
            
        }
    }
}
