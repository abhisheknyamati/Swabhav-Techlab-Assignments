using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiterApp
{
    internal class Inventory
    {
        public List<Guitar> guitarList = new List<Guitar>();

        public void AddGuitar()
        {
            Console.WriteLine("Enter the following details to Add Guitar in list :");
            Console.WriteLine("Serial Number : ");
            string serialNumber = Console.ReadLine();
            Console.WriteLine("Price : ");
            if (!double.TryParse(Console.ReadLine(), out double price))
            {
                Console.WriteLine("Invalid input format");
                return;
            } 
            Console.WriteLine("Builder : ");
            string builder = Console.ReadLine();
            Console.WriteLine("Model : ");
            string model = Console.ReadLine();
            Console.WriteLine("Type : ");
            string type = Console.ReadLine();
            Console.WriteLine("Back Wood : ");
            string backWood = Console.ReadLine();
            Console.WriteLine("Top Wood : ");
            string topWood = Console.ReadLine();    
            
            Guitar newGuitar = new Guitar(serialNumber, price, builder, model, type, backWood, topWood);
            guitarList.Add(newGuitar);
            Console.WriteLine("New Guitar is successfully added to the list.");
        }

        public Guitar GetGuitar(string serialNumber)
        {
            Guitar foundGuitar = guitarList.Find(guitar => guitar.SerialNumber == serialNumber);
            if (foundGuitar == null)
            {
                Console.WriteLine("ERROR 404 : Guitar not found.");
                return null;
            }
            return foundGuitar;
        }

        public void DisplayAvailableGuitars()
        {
            Console.WriteLine("All available Guitars are : ");

            Console.WriteLine("{0,-15} {1,-10} {2,-15} {3,-10} {4,-15} {5,-15} {6,-15}",
                "Serial Number", "Price", "Builder", "Model", "Type", "Back Wood", "Top Wood");

            Console.WriteLine(new string('-', 95));

            foreach (Guitar guitar in guitarList)
            {
                Console.WriteLine("{0,-15} {1,-10} {2,-15} {3,-10} {4,-15} {5,-15} {6,-15}",
                    guitar.SerialNumber,
                    guitar.Price,
                    guitar.Builder,
                    guitar.Model,
                    guitar.Type,
                    guitar.BackWood,
                    guitar.TopWood);
            }

            Console.WriteLine(new string('-', 95));
        }
    }
}
