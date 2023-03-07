internal class Program
{
    static int Addition(int x, int y)
    { 
        return x + y; 
    }
    static double Addition(double x, double y)
    {
        return x + y;
    }

    static void Main(string[] args)
    {
        
        int i = Program.Addition(1, 2);
        Console.WriteLine("Int:" +i);
        double j = Program.Addition(1.3, 1.2);
        Console.WriteLine("Double:" +j);

    }
}