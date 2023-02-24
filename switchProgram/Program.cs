//Console.WriteLine("Hello, World!");

internal class Program
{
    private static void Main(string[] args)
    {
        //int day = 4;
        //switch (day)
        //{
        //    case 1:
        //        Console.WriteLine("Monday");
        //        break;
        //    case 2:
        //        Console.WriteLine("Tuesday");
        //        break;
        //    case 3:
        //        Console.WriteLine("Wednesday");
        //        break;
        //    case 4:
        //        Console.WriteLine("Thursday");
        //        break;
        //    case 5:
        //        Console.WriteLine("Friday");
        //        break;
        //    case 6:
        //        Console.WriteLine("Saturday");
        //        break;
        //    case 7:
        //        Console.WriteLine("Sunday");
        //        break;
        //}

        {

            Console.WriteLine("please input A");

            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please input B");

            int b = Convert.ToInt32(Console.ReadLine()); string op = Console.ReadLine(); switch (op)

            {

                //It's a placeholder in the string.

                case "+": Console.WriteLine("addition of two numbers is{0}", a + b); break;

                case "-": Console.WriteLine("substraction of two numbers is{0}", a - b); break;

                case "*": Console.WriteLine("multiplication of two numbers is{0}", a * b); break;

            }
            Console.ReadLine();
        }

    }

}
 