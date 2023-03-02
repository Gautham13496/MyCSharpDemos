
    class Empdata
    { 
   
        private string Empname = "Siva";
        private int EmpId = 3831;
        class Emp
        {
            static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Empdata empdetails = new Empdata();
            Empdata empfulldetails = new Empdata();

            Console.WriteLine(empdetails.Empname + " " + empdetails.EmpId);
            Console.WriteLine(empfulldetails.Empname + " " + empfulldetails.EmpId);
        }
    }
}
