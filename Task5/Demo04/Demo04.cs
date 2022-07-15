using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueAndReferenceType
{
    class testA
    {
        public String name;
    }
    class Demo04
    {
        static void Main(string[] args)
        {
            int z = 10;
            String str = "Hello World";
            Console.WriteLine("****Test value type:");
            Console.WriteLine("The value of z before: " + z);
            changeValue(z);
            Console.WriteLine("The value of z after: " + z);

            Console.WriteLine("****Test reference type: ");
            testA a = new testA();
            a.name = "not changed!";
            Console.WriteLine("The value of str before: " + a.name);
            changeValue2(a);
            Console.WriteLine("The value of str after: " + a.name);

            Console.ReadLine();
        }
        public static void changeValue(int k)
        {
            k = 10;
        }
        public static void changeValue2(testA v)
        {
            v.name = "change it";
        }
    }
}