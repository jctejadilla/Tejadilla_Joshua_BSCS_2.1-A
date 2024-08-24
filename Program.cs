using System;
namespace DataTypesApp{

public class DataTypesProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Enter a pieces of apple: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine ($"Enter total price of {a} apple(s): ");
        double b = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine ("=====================================");
        Console.WriteLine ($"the total price of {a} apple(s) is " + b);
        Console.WriteLine ("the value of original price is " + b);
        
        int c = (int) b;
        Console.WriteLine ("the value of converted price is " + c);
        Console.WriteLine ("=====================================");
    }
}
}