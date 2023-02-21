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



    }
}