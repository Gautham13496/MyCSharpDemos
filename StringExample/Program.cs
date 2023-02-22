using System.Reflection.Metadata.Ecma335;

internal class Program
{
    /// <summary>
    /// 
    /// 
    /// </summary>
    /// <param name="args">Main </param>
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        string Fname = "GAUTHAM";
        string Lastname = "VAJRAM";
        int age = 27;
        string Fullname = Fname+ Lastname;

        Console.WriteLine("My Fullname is" + Fullname + " " + "and my age is" + " " + age);

        Console.WriteLine("My Fullname is" + string.Concat(Fname+Lastname) + " " + "and my age is" + " " + age);

        Console.WriteLine("My Fullname is" + string.Concat(Fname + Lastname) + "@" + age);

        Console.WriteLine($"My Fullname is  {Fname} {Lastname} and age is {age} ");    //$ ->string Interpolation 

        Console.WriteLine("My Fullname is {0} {1}  and age is {2} ", "Fname","Lastname","age"); //--> string Interpolation2

        string Name = "   GAUTHAM  ";
        
        string whitespace = Name.Replace(" ", string.Empty);

        Console.WriteLine(Name.Trim());


        Console.Write("Enter your Age:");
        String strage = Console.ReadLine();
        int Age = Convert.ToInt32(strage);
        Console.WriteLine("You are " + Age + " year old");



        Console.Write("Enter your Age1:");
        String strage1 = Console.ReadLine();
        int Age1 = int.Parse(strage1);
        Console.WriteLine("You are " + Age1 + " year old");


      




    }
     

}