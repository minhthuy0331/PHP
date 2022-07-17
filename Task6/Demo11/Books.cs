using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore
{
    class Books
    {
        static void Main(string[] args)
        {
            string[] bookTitle = new string[6];
            for(int i = 0; i<bookTitle.Length; i++)
            {
                Console.Write("Enter the title pf book : ");
                bookTitle[i] = Console.ReadLine();
                Console.WriteLine();
            }

            // Displaying the title of the Books
            Console.WriteLine("List of books: ");
            foreach(string title in bookTitle)
            {
                Console.WriteLine(title);
            }
            // Changing the title of fourth book
            bookTitle[3] = "Planet of the Apes";
            Console.WriteLine("Newly changed title of book 4: " + bookTitle[3]);
        }
    }
}