using System.Runtime.InteropServices;

class Program
{
    public class BS5

    {

        public int cc = 250;

        public float price = 279322.00f;

        public string name = "ThunderBird";

        public string brand = "RoyalEnfield";

        public void display()

        {

            string str = "cc =" + cc + "," + "Price=" + price + "," + "name=" + name + "," + "Brand=" + brand;

            Console.WriteLine(str);

        }

    }

    public class BS6 : BS5

    {

        public new int cc = 200;

        public float price = 250000.00f;

        public string name = "Duke";

        public string brand = "KTM";        // string str = "Hello " + userName + ". Today is " + dateString + ".";

        public void show()

        {

            string str = "cc =" + cc + "," + "Price=" + price + "," + "name=" + name + "," + "Brand=" + brand;

            Console.WriteLine(str);

        }

    }

    public class BS7 : BS6

    {

        public string colour = "Red";

        public int stroke = 2;

        public string name = "ThunderBird";

        public void specification()

        {

            string str = "colour =" + colour + "," + "stroke =" + stroke + "," + "name =" + name;

            Console.WriteLine(str);

        }

    }

    public class BS8 : BS7

    {

        public string colour = "Yellow";

        public int stroke = 2;

        public string name = "Duke";

        public void identification()

        {

            string str = "colour =" + colour + "," + "stroke =" + stroke + "," + "name =" + name;

            Console.WriteLine(str);

        }

    }

    class TestInheritence

    {

        public static void Main(string[] args)

        {

            BS8 b1 = new BS8();

            b1.display();

            b1.show();

            b1.specification();

            b1.identification();

        }

    }
}