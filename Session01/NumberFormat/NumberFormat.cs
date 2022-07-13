using System;
class NumberFormat
{
    static void Main(string[] args)
    {
        Console.WriteLine("Currency formatting - {0:c} {1:C4}", 88.8, 888.8);
        Console.WriteLine("Intefer formatting - {0:D5}", 88);
        Console.WriteLine("Exponential formatting - {0:E}", 888);
        Console.WriteLine("Fixed-point formatting - {0:F3}", 888.8888);
        Console.WriteLine("General formatting - {0:G}" , 888.8888);
        Console.WriteLine("Number formatting - {0:N}", 8888888.8);
        Console.WriteLine("Hexadecinaml formatting - {0:X4}", 88);
    }
}
