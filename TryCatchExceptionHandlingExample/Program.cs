internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            int [] pincode = {5,1,7,0,0};
            Console.WriteLine(pincode[6]);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("Pincode is not valid....");
        }
        finally { Console.WriteLine("Please provide a valid 6 digit pincode!"); }
        Console.ReadLine();
    
    }
}