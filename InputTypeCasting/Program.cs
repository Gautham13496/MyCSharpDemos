class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter First Number:");
        int FirstNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Second Number:");
        int SecondNumber = Convert.ToInt32(Console.ReadLine());


        int Add = (FirstNumber + SecondNumber);
        int Sub = (FirstNumber - SecondNumber);
        double Multiply = Convert.ToDouble(FirstNumber * SecondNumber);
        decimal Div = Convert.ToDecimal(FirstNumber / SecondNumber);

        Console.WriteLine("The Add is :" + Add);
        Console.WriteLine("The Sub is :" + Sub);
        Console.WriteLine("The Multiply is :" + Multiply);
        Console.WriteLine("The Div is :" + Div);

     
    }
        
}