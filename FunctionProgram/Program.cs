internal class Program
{
    static int plusmethodInt(int x,int y)
    { return x + y; }

    static void Main(string[] args)
    {
        Program pr = new Program();
       int i =  Program.plusmethodInt(1, 2);
        
        Console.WriteLine(i);

        
    }
}