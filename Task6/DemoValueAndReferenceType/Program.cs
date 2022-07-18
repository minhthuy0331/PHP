using System;
using System.Collections.Generic;
using System.Text;

namespace DemoValueAndReferenceType
{
    class Student
    {
        public int id;
        public String name;
        public int age;
     
    }
    class Program
    {
        static void Main(string[] args)
        {
            int mark = 10;
            String str = "Diem Thi";
            Console.WriteLine("****Test value type: ");
            Console.WriteLine("The value of mark before: " + mark);
            changeValue(mark);
            Console.WriteLine("The value of mark after: " + mark);

            Console.WriteLine("****Test reference type:");
            Student stud = new Student();
            stud.id = 1;
            stud.name = "Alert";
            stud.age = 25;
            Console.WriteLine("The value of student before: " +"ID: " + stud.id +", Name:" + stud.name + ", Age:" +  stud.age);
            changeValue2(stud);
            Console.WriteLine("The value of student after: " + "ID: " + stud.id + ", Name:" + stud.name + ", Age:" + stud.age);

            Console.ReadLine();

        }
        public static void changeValue(int m)
        {
            m = 10;
        }
        public static void changeValue2(Student stud2)
        {
            stud2.id = 2;
            stud2.name = "Linda";
            stud2.age = 18;
        }
    }
}
