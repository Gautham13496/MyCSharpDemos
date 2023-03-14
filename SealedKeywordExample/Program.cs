sealed public class Animal

{
    public void eat()

    { Console.WriteLine("eating...");    }
}

public class Dog : Animal

{

    public void bark()

    { Console.WriteLine("barking..."); }

}

public class TestSealed

{

    public static void Main()

    {

        Dog d = new Dog();

        Animal an = new Animal();

        d.eat();

        d.bark();

        an.eat();

    }

}

