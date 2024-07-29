using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieDLL.Services;

public class MovieStore 
{   
    public static void Menu()
    {   
        Console.WriteLine("---------------------");
        Console.WriteLine("|      Welcome      |"); 
        Console.WriteLine("---------------------");
        bool user = true;
        do
        {
            Console.WriteLine("Choose from the options given below :\n1. Add Movies \n2. Display Movies \n3. Delete Movies\n0. EXIT");
            if(!int.TryParse(Console.ReadLine(), out int userInput)){
                Console.WriteLine("Enter a valid number");
                continue;
            }

            MovieManager movieManager = new MovieManager();
            switch (userInput)
            {
                case 1:
                    movieManager.AddMovies();
                    break;
                case 2:
                    movieManager.DisplayMovies();
                    break;
                case 3:
                    movieManager.DeleteMovie();
                    break;
                case 0:
                    user = false;
                    Console.WriteLine("Thank You for using for our application.");
                    break;
                default:
                    Console.WriteLine("Enter a valid input.");
                    break;
            }
            Console.WriteLine();
        } while (user);
    }
}