using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Customers
    {
        static void Main(string[] args)
        {
            // Arrays of string type to store customer name and city
            string[] customerName = new string[3];
            string[] city = new string[3];

            // Array of integers to store customer age
            int[] age = new int[3];

            // Array of character to store customer gender
            char[] gender = new char[3];

            // String variable to store the name of city
            string cityName;

            // Integer variable to store the total number of customers in a city
            int total = 0;

            int i = 0;
            do
            {
                // Accepting the details of customer using do-while loop
                Console.Write("Enter the name of customer: ");
                customerName[i] = Console.ReadLine();

                Console.Write("Enter the age: ");
                age[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter gender [M/F]: ");
                gender[i] = Convert.ToChar(Console.ReadLine());

                Console.Write("Enter city: ");
                city[i] = Console.ReadLine();
                Console.WriteLine();
                i++;

            } while (i < customerName.Length);

            // Displaying the details of customers using for loop
            Console.WriteLine("Custmoer Details: ");
            Console.WriteLine("name         \tAge \tGender \tCity");
            for(i = 0; i < customerName.Length; i++)
            {
                Console.Write("{0} \t{1}  \t", customerName[i], age[i]);
                if (gender[i] == 'M' || gender[i] == 'm')
                    Console.Write("Male \t");
                else
                    Console.Write("Female \t");
                Console.WriteLine("{0}", city[i]);
            }
            // Displaying the names of customers using foreach loop
            Console.WriteLine("\nNames of Customers:");
            foreach(string names in customerName)
            {
                Console.WriteLine("{0}", names);
            }

            // Acceping the name of city
            Console.Write("Enter the name of city whose records you want to view: ");
            cityName = Console.ReadLine();

            // Displaying the details of customers according to the choice entered using while loop
            Console.WriteLine("\nCustomer Details ({0}) : ", cityName);
            Console.WriteLine("Name        \tAge \tGerder \tCity");
            i= 0;
            while(i < customerName.Length)
            {
                if (city[i] == cityName)
                {
                    Console.Write("{0} \t{1} \t", customerName[i], age[i]);
                    if (gender[i] == 'M' || gender[i] == 'm')
                        Console.Write("Male \t");
                    else
                        Console.Write("Female \t");
                    Console.WriteLine("{0}", city[i]);
                    total++;
                }
                i++;
            }
            // Displaying the total number of customers according to the choice entered
            Console.WriteLine("No. Of customers in {0} : {1}", cityName, total);

        }
    }
}