// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main()
    {
        flipkart f = new flipkart();    
        f.a = 10;
        f.b = 20;

        Console.WriteLine($"Addition : {f.a} + {f.b} =  {f.add()}");
    }
}