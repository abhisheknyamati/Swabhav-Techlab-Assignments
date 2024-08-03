using College_ManyToOne;
using College_ManyToOne.Model;

class Program
{
    public static void Main(string[] args)
    {
        CollegeDetails college = new CollegeDetails(1, "DMCE");

        Department department1 = new Department(100, "CS");
        Department department2 = new Department(200, "IT");
        Department department3 = new Department(300, "ME");
        Department department4 = new Department(400, "EXTC");

        college.departments.Add(department1);
        college.departments.Add(department2);
        college.departments.Add(department3);
        college.departments.Add(department4);

        Professor professor1 = new Professor(101, "Max");
        Professor professor2 = new Professor(102, "Carl");
        Professor professor3 = new Professor(103, "Sam");
        Professor professor4 = new Professor(104, "Ozil");

        college.professors.Add(professor1);
        college.professors.Add(professor2);
        college.professors.Add(professor3);
        college.professors.Add(professor4);

        Student student1 = new Student(1, "abhishek");
        Student student2 = new Student(2, "goldy");
        Student student3 = new Student(3, "aten");
        Student student4 = new Student(4, "rohan");

        college.students.Add(student1);
        college.students.Add(student2);
        college.students.Add(student3);
        college.students.Add(student4);

        MainMenu menu = new MainMenu();
        menu.Menu(college, college.students, college.professors, college.departments);
    }
}