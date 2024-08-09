using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    public class RealImage : IImage
    {
        private string filename;

        public RealImage(string filename)
        {
            this.filename = filename;
            LoadImageFromDisk();
        }

        private void LoadImageFromDisk()
        {
            Console.WriteLine("Loading image: " + filename + " //image is being loaded from disk");
        }

        public void Display()
        {
            Console.WriteLine("Displaying image: " + filename);
        }
    }

}
