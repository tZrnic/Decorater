using Decorater;

public class Program()
{
    public static void Main()
    {
        ICoffee MilkCoffee = new Milk(new Espresso());

        Console.WriteLine("Description: " + MilkCoffee.GetDescription());
        Console.WriteLine("Price: " + MilkCoffee.GetPrice());

        ICoffee espresso = new Espresso();

        Console.WriteLine("Description: " + espresso.GetDescription());
        Console.WriteLine("Price: " + espresso.GetPrice());
    }
}
