using System;
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

        //string Fname = "GAUTHAM";
        //string Lastname = "VAJRAM";
        //int age = 27;
        //string Fullname = Fname+ Lastname;

        //Console.WriteLine("My Fullname is" + Fullname + " " + "and my age is" + " " + age);

        //Console.WriteLine("My Fullname is" + string.Concat(Fname+Lastname) + " " + "and my age is" + " " + age);

        //Console.WriteLine("My Fullname is" + string.Concat(Fname + Lastname) + "@" + age);

        //Console.WriteLine($"My Fullname is  {Fname} {Lastname} and age is {age} ");    //$ ->string Interpolation 

        //Console.WriteLine("My Fullname is {0} {1}  and age is {2} ", "Fname","Lastname","age"); //--> string Interpolation2

        //string Name = "   GAUTHAM  ";
        
        //string whitespace = Name.Replace(" ", string.Empty);

        //Console.WriteLine(Name.Trim());


        //Console.Write("Enter your Age:");
        //String strage = Console.ReadLine();
        //int Age = Convert.ToInt32(strage);
        //Console.WriteLine("You are " + Age + " year old");



        //Console.Write("Enter your Age1:");
        //String strage1 = Console.ReadLine();
        //int Age1 = int.Parse(strage1);
        //Console.WriteLine("You are " + Age1 + " year old");




        //string myString = "Hello";
        //Console.WriteLine(myString[0]);



        //string myString1 = "Hello";
        //Console.WriteLine(myString.IndexOf("e"));

        //string name = "SAMEER";

        //Console.WriteLine(name.Substring(1,4));

        //string txt = "We are the so-called \"Vikings\" from the north.";
        //Console.WriteLine(txt);

        //string txt1 = "Hello World";
        //Console.WriteLine(txt1.ToUpper());   // Outputs "HELLO WORLD"
        //Console.WriteLine(txt1.ToLower());   // Outputs "hello world"


        //string txt2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        //Console.WriteLine("The length of the txt string is: " + txt2.Length);

      
        Console.WriteLine("Please Enter A:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please Enter B:");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please Enter C:");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please Enter D:");
        int d = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please Enter E:");
        int e = Convert.ToInt32(Console.ReadLine());


        if (a > b && a > c && a > d && a>e)
        {
            Console.WriteLine("A is greater");
        }

        else if (b > c && b > d && b > a && b>e)
        {
            Console.WriteLine("B is greater");
        }
        else if (c > a && c > b && c > d && c>e)
        {

            Console.WriteLine("C is greater");

        }
        else if(d>a && d>b && d>c && d>e)
        {
            Console.WriteLine("D is greater");

        }
        else
        {
            Console.WriteLine("E is greater");

        }



    }
     

}