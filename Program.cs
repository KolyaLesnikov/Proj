using System;
using Mawinka;





class Program
{
    static int Factorial(int x)
    {
        if (x == 0)
            return 1;
        return x * Factorial(x - 1);
    }
    public static void Main(string [] args)
    {
        System.Console.WriteLine("Hello world");
        System.Console.WriteLine("Mish commit"); 
        System.Console.WriteLine(Factorial(5));

        List<Car> cars = Car.GetCars();
        foreach (Car item in cars)
        {
            Console.WriteLine($"{item.Title} ");
        }
    }
   
    
}