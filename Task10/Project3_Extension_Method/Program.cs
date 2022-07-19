using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extension_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = "Great Britain";
            // Calling the extension method
            Console.WriteLine(country.FirstLetterLower());

            // use List
            List<string> cities = new List<string>();
            cities.Add("Seoul");
            cities.Add("Beijing");
            cities.Add("Berlin");
            cities.Add("Istanbul");
            cities.Add("Seoul");
            cities.Add("Istanbul");
            cities.Add("Paris");

            // Invoke the Extension method, RemoveDuplicate()
            List<string> result = cities.RemoveDulicaticate();
            foreach(string city in result) 
                Console.WriteLine(city);
        }
    }
}