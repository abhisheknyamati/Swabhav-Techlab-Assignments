class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Entity Frame");
        StudentRepository studentRepository = new StudentRepository();
        studentRepository.AddStudent();
       
    }
}
