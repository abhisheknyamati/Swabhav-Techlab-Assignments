using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieDLL.Model;
using Newtonsoft.Json;

namespace MovieDLL.Services
{
    public class SerializeDeserialize
    {
        public static void Serialize(List<Movie> movies)
        {
            File.WriteAllText("MovieData.json", JsonConvert.SerializeObject(movies));
        }

        public static List<Movie> Deserialize()
        {
            List<Movie> movies = new List<Movie>();
            string fileName = "MovieData.json";
            if (File.Exists(fileName))
            {
                string json = File.ReadAllText(fileName);
                movies = JsonConvert.DeserializeObject<List<Movie>>(json);
            }
            else
            {
                File.WriteAllText(fileName, JsonConvert.SerializeObject(movies));
            }
            return movies;
        }
    }
}
