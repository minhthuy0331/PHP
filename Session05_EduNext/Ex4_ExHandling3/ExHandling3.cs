using System;
class MainClass
{
    public static int AnExceptionFunction(int value)
    {
        if (value == 0) // Can't divide by zezo
            throw new DivideByZeroException("Divide By 0 error!");
        int x = 20;
        return x;
    }
    public static void Main()
    {
        int value = 0;
        try
        {
            value = AnExceptionFunction(10);
            Console.WriteLine("Value = {0}", value);
            AnExceptionFunction(0);
            Console.WriteLine("Value = {0}", value);
        }
        catch(Exception e)
        {
            Console.WriteLine("Caught an expection {0}. Continuing", e);
        }
        Console.WriteLine("Done");
    }
}
