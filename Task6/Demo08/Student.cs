using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    class Student
    {
        static void Main(string[] args)
        {
            string studentName;
            int english, maths, science;
            float percent = 0, amount = 0;
            Console.Write("Enter the name of the student: ");
            studentName = Console.ReadLine();

            Console.Write("Enter marks in English: ");
            english = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks in Maths: ");
            maths = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks in Science: ");
            science = Convert.ToInt32(Console.ReadLine());

            // checking if marks are greater than or equal to zezo
            // and less than or equal to 100
            if ((english >= 0) && (english <= 100) && ( maths >= 0 && maths <= 100) && (science >= 0 && science <= 100))
            {
                if(english >=35 && maths >=35 && science >=35)
                {
                    percent = ((english + maths + science) * 100) / 300;

                    // calculating schoolarship amount
                    if (percent > 75)
                        amount = 1500;
                    else if (percent >= 60 && percent <= 75)
                        amount = 1000;
                    else
                        amount = 0;

                    // Displaying the student name, total marks and the
                    // percentage obtained by the student
                    Console.WriteLine("\nStudent Name: " + studentName);
                    Console.WriteLine("Total Marks: " + (english + maths + science));
                    Console.WriteLine("Percentage: " + percent + "%");

                    // Displaying scholarship amount for the student
                    Console.WriteLine("Scholarship Amount: " + amount + "%");

                }
                else
                {
                    Console.WriteLine("\nStudent Name: " + studentName);
                    Console.WriteLine("Result : Failed");
                }
            }
            else
            {
                Console.WriteLine("Invalid entry of marks");
            }

        }
    }
}