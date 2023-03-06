class emp
{
    internal string empname = "Gautham";
    internal int empid = 3831;

    public void Namedetails()

    {
        Console.WriteLine("Name is:" + empname + "," + "id is:" + empid);


    }
}
    public class Program
{
     static void Main(string[] args)
    {
        emp theemp= new emp();
        Console.WriteLine("Name:" + theemp.empname);
       theemp.Namedetails();
        Console.WriteLine("\nPress any key to exit from the window....");
    }
}
