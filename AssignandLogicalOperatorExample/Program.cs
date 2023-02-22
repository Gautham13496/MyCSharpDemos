using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");

        Console.WriteLine("Enter Number:");
        int Number = Convert.ToInt32(Console.ReadLine());

        int increment = (Number++);
        int decrement = (Number--);
        int addequal = (Number += 2);
        int multiplyequal = (Number *= 2);




        Console.WriteLine("The increment is :" + increment);
        Console.WriteLine("The decrement is :" + decrement);
        Console.WriteLine("The addequal is :" + addequal);
        Console.WriteLine("The multiplyequal is :" + multiplyequal);

        int x = 5;
        x++;   //+1
        x--;   //-1             
        x += 3;
        x *= 2;
        x -= 5;


        int Z = 5;
        int y = 3;
        int Result = 5;
        Console.WriteLine(Result > 3 && Result < 10);
        Console.WriteLine(x > 3 || x < 4);
        int C = 5;
        Console.WriteLine(!(C > 3 && C < 10));             //Console.WriteLine(!(x > 3 && x < 10));
        Console.WriteLine(Z != y);
        Console.WriteLine(Z > y); // returns True because 5 is greater than 3   

        Console.WriteLine(Math.Min(5, 10));  //For Min Value            
        Console.WriteLine(Math.Max(5, 10));  //For Max Value 
        Console.WriteLine(Math.Sqrt(81));    //For  square root              
        Console.WriteLine(Math.Abs(-4.7));   //For Positive value of Number             
        Console.WriteLine(Math.Round(9.52));
        Console.WriteLine(x);


    }
}