class Program
{
    class Laptop
    {
        string Model;
        string color;
        int price;
        
        public void laptopfunction()
        {
            Console.WriteLine("Please show me a good choice:");
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Laptop Laptopdata = new Laptop();
            Laptopdata.Model = "Dell";
            Laptopdata.color = "red";
            Laptopdata.price   = 70000;

            Console.WriteLine(Laptopdata.Model+" "+Laptopdata.color+" "+Laptopdata.price);

            Laptopdata.laptopfunction();

        }
    }
}
