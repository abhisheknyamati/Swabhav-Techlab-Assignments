using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    public class ProxyImage : IImage
    {
        private RealImage realImage;
        private string filename;

        public ProxyImage(string filename)
        {
            this.filename = filename;
        }

        public void Display()
        {
            if (realImage == null)
            {
                realImage = new RealImage(filename);
            }
            realImage.Display();
        }
    }

}
