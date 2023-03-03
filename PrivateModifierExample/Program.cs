#region
class Program

{ 

}

class Student

{

    private string? name;

    private int age;

    private string? Address; private void PrintStudentDetails()

    {

        Console.WriteLine("Name is:" + name);

        Console.WriteLine("age is:" + age);

        Console.WriteLine("Address is:" + Address);

        Console.ReadLine();

    }

    static void Main(string[] args)

    {

        //Console.WriteLine("Hello World!");

        Student studentinfo = new Student();

        studentinfo.name = "Sam";

        studentinfo.age = 29;

        studentinfo.Address = "Bangalore";

        studentinfo.PrintStudentDetails();

    }
}
#endregion