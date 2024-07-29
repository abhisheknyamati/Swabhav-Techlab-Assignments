using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieDLL.GlobalExceptionHandling;
using MovieDLL.Model;

namespace MovieDLL.Services
{
    public class MovieManager : Movie
    {   
        public MovieManager() 
        {
            movies = SerializeDeserialize.Deserialize();
        }

        public static List<Movie> movies = new List<Movie>();
        public void AddMovies()
        {
            try
            {
                if (movies.Count == 3)
                {
                    throw new MaximumMovieCapacityEx("Maximum Capacity of Movies is Reached!");
                }
                Movie movie = new Movie();

                Console.WriteLine("Enter Name of Movie : ");
                movie.Name = Console.ReadLine();

                Console.WriteLine("Enter Genre of Movie : ");
                movie.Genre = Console.ReadLine();

                Console.WriteLine("Enter Year of Release : ");
                movie.Year = int.Parse(Console.ReadLine());

                movie.Id = movie.Name.Substring(0, 2) + movie.Genre.Substring(0, 2)
                    + movie.Year.ToString().Substring(2, 2);
                movies.Add(movie);

                SerializeDeserialize.Serialize(movies);
                Console.WriteLine("Movie added sucessfully");
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        public void DisplayMovies()
        {
            try
            {
                if (movies.Count != 0)
                {
                    Console.WriteLine("---------------------List of Movies------------------");
                    Console.WriteLine($"| {"ID",-10} | {"Name",-10} | {"Genre",-10} | {"Year",-10} |");
                    Console.WriteLine("-----------------------------------------------------");
                    foreach (var movie in movies)
                    {
                        Console.WriteLine($"| {movie.Id,-10} | {movie.Name,-10} | {movie.Genre,-10} | {movie.Year,-10} |");
                    }
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine($"| {"Moives Count",-45} | {movies.Count} |");
                    Console.WriteLine("-----------------------------------------------------");

                    SerializeDeserialize.Serialize(movies);
                }
                else { throw new MovieStoreEmptyEx("No Movies Available!"); }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        public void DeleteMovie()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter the Movie Id to delete : ");
                    string movieId = Console.ReadLine();
                    int removedMovies = movies.RemoveAll(movie => movie.Id == movieId);

                    if (removedMovies > 0)
                    {
                        SerializeDeserialize.Serialize(movies);
                        Console.WriteLine("Movie deleted sucessfully.");
                        break;
                    }
                    else
                    {
                        throw new Exception("Enter Valid Movie ID\n");
                    }

                    
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
                
            }

        }

    }
}
