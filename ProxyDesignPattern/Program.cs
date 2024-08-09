namespace ProxyDesignPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Proxy Design Pattern\n");
            IImage image = new ProxyImage("example.jpg");

            image.Display();
            Console.WriteLine("// Image will be loaded from disk only when Display() is called ");

            Console.WriteLine("\n// Image will not be loaded again, as it has been cached in the Proxy");

           image.Display();
        }
    }
}