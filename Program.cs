using System.Xml.Linq;

class Program
{
    static void Main()
    {
    }
}

class Student
{
    string Name { get; set; }
    string LastName { get; set; }
    int Age { get; set; }

    public Student(string name,string lastName, int age)
    {
        Name = name;
        LastName = lastName;
        Age = age;
    }

    public Student ()
    {
        
    }

    public void PrintStudent()
    {
        Console.WriteLine("Name: ", Name);
        Console.WriteLine("Last name: ", LastName);
        Console.WriteLine("Age: ", Age);
    }

    public void CreateStudent()
    {
        Console.WriteLine("Name: ");

        string name = Console.ReadLine();

        Console.WriteLine("Last name: ");

        string lastName = Console.ReadLine();

        Console.WriteLine("Age: ");

        int age = Convert.ToInt32(Console.ReadLine());

        Name = name;
        LastName = lastName;
        Age = age;
    }
}

class Teacher : Student
{
    string Lesons;

    public Teacher (){}

    public Teacher(string name, string lastName, int age,string lesons) : base(name, lastName, age)
    {
        Lesons = lesons;
    }

    public void CreateTeacher()
    {
        CreateStudent();
        Console.WriteLine("Lesens: ");
        Lesons = Console.ReadLine();
    }

    public void PrintTecher()
    {
        PrintStudent();
        Console.WriteLine("Lesons: ", Lesons);
    }
}

class DayTimetable
{
    string Day;
    string ListLesons;
    int HowManyLessons;

    public void  CreatDay(string day,int n)
    {
        HowManyLessons = n;

        for (int i = 0; i < n; i++)
        {
            Console.Write("1.");

            string lesons = Console.ReadLine();

            ListLesons += n + '.'+ lesons + ' ';
        }
    }
}

class Timetable
{
    DayTimetable Monday = new DayTimetable();
    DayTimetable Tuesday = new DayTimetable();
    DayTimetable Wednesday = new DayTimetable();
    DayTimetable Thursday = new DayTimetable();
    DayTimetable Friday = new DayTimetable();

    void CreateTimetable(int n)
    {
        Monday.CreatDay("Monday", n);
    }
}

class Clas
{
    List<Student> ListStudent = new List<Student>();
    int Quantity;
    string NameClas;

    Clas() { }

    void PrintClas()
    {
        Console.WriteLine("Clas name: ", NameClas);

        for(int i=0;i< Quantity;i++)
        {
            ListStudent[i].PrintStudent();
        }
    }

     public void CreateClas()
    {
        int quantity = Console.Read();
        Quantity = quantity;

        var listStudent = new List<Student>();

        for (int i = 0; i < quantity; i++)
        {
            var student = new Student();

            student.CreateStudent();

            listStudent.Add(student);
        }

        var teacher = new Teacher();

        teacher.CreateTeacher();

        Console.Write("Name clas: ");

        NameClas = Console.ReadLine();

    }

    void AddStudent()
    {
        var student = new Student();

        student.CreateStudent();

        ListStudent.Add(student);
    }

    class Shool
    {
        List<Clas> ClasList = new List<Clas>();
        int HowManyClas;
        List<Teacher> TeacherList= new List<Teacher>();
        int HowManyTeacher;

       public void CreatShool(int howManyClas, int howManyTeacher)
        {
            for (int i = 0; i < howManyClas; i++)
            {
                Teacher teacher = new Teacher();

                teacher.CreateTeacher();

                TeacherList.Add(teacher);
            }

            for (int i = 0; i < howManyTeacher; i++)
            {
                Clas clas = new Clas();

                clas.CreateClas();

                ClasList.Add(clas);
            }
        }
       public void PrintShool()
       {
           for(int i=0; i < HowManyClas; i++)
           {
               Console.WriteLine("Clas list: ");
               ClasList[i].PrintClas();
           }
           for (int i = 0; i < HowManyTeacher; i++)
           {
               Console.WriteLine("Techar list: ");
               TeacherList[i].PrintTecher();
           }
       }
    }
}
