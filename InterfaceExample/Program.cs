interface IMenu

{

    public void UN(); // interface method

}
interface ILoginPage

{

    void PW(); // interface method

}     // Implement multiple interfaces

class TrailClass :IMenu, ILoginPage

{

    public void UN()

    {

        Console.WriteLine("Username is:Gautham");

    }

    public void PW()

    {

        Console.WriteLine("Password is:DOTNET");

    }

}
class Program

{

    static void Main(string[] args)

    {

        TrailClass myObj = new TrailClass();

        myObj.UN();

        myObj.PW();
        Console.ReadLine();

    }

}