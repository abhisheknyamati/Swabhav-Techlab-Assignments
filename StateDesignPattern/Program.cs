namespace StateDesignPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("State Design Pattern\n");

            TCPConnection connection = new TCPConnection();

            connection.Request(); // Handles in Listening state
            Console.WriteLine("//Handles in Listening state\n");
            connection.Request(); // Handles in Established state
            Console.WriteLine("//Handles in Established state\n");
            connection.Request(); // Handles in Closed state
            Console.WriteLine("//Handles in Closed state\n");

        }
    }
}