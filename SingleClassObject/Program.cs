class Program
{
    class Emp
    {
        string Empname = "Gautham";
        int EmpId = 3831;

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Emp empdetails = new Emp();
            Emp empfulldetails = new Emp();
            
            Console.WriteLine(empdetails.Empname +" " +empdetails.EmpId);
            Console.WriteLine(empfulldetails.Empname +" " +empfulldetails.EmpId);
        }
    }
}