// See https://aka.ms/new-console-template for more information



using System;

class Program
{
    static void Main(string[] args)
    {

        int myInt = 1005;
        double myDouble = myInt; // Automatic casting Int to Double

        float Floatnumber = 1005.125f;
        double Doublenumber = Floatnumber;   // Automatic catins float to double

        double Trial = 9.78;
        int x = (int)Trial;

        Console.WriteLine(myInt);
        Console.WriteLine(myDouble);
        Console.WriteLine(Doublenumber);
        Console.WriteLine(x);
        Console.ReadLine();

    }
}
