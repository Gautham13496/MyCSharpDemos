//Console.WriteLine("Hello, World!");

internal class Program
{
    private static void Main(string[] args)
    {
        int[,] Numbers = { { 1, 2, 3 }, { 4, 5, 6 } };

        Console.WriteLine(Numbers[0, 1]);



        Numbers[1, 0] = 5;  // Change value to 5 //Change Elements  

        Console.WriteLine(Numbers[1, 0]);

        foreach (int i in Numbers)  //Forloop

        {

            Console.WriteLine(i);

        }

        for (int i = 0; i < Numbers.GetLength(0); i++)  //Length--->GetLength ///FirstArray

        {

            for (int j = 0; j < Numbers.GetLength(1); j++) //Second Array 

            {

                Console.WriteLine(Numbers[i, j]);

            }

        }
    }
}