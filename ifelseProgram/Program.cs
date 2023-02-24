internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        Console.WriteLine("age:");
        double age1 = Convert.ToDouble(Console.ReadLine());




        if (age1 == 18)
        {
            Console.WriteLine("Eligible for marriage");
        }
        else if (age1 > 18)
        {
            Console.WriteLine("You can get married");

        }
        else
        {
            Console.WriteLine("You be single forever");
        }







    }
}