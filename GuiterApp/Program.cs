namespace GuiterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            Console.WriteLine("Welcome to Guiter Finding Application\n");
            int userInput;
            while (true)
            {
                Console.WriteLine("Choose from following options, ");
                Console.WriteLine("1.Add Guitar \n2.Get Guitar \n3.Search Guitar \n4.Display all available guitars \n0.Exit");
                while (true)
                {
                    Console.Write("Enter your choice: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out userInput) && userInput >= 0 && userInput <= 4)
                    {
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number between 0 and 4.");
                    }
                }
                switch (userInput)
                {
                    case 0:
                        Console.WriteLine("Thank You for using our application.");
                        return;
                    case 1:
                        inventory.AddGuitar();
                        break;
                    case 4:
                        inventory.DisplayAvailableGuitars();
                        break;
                    default:
                        Console.WriteLine("Invalid Input! Enter again...");
                        continue;
                }
            }
        }
    }
}