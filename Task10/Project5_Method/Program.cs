using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Method
{
    class Book
    {
        string _bookName;
        public string Print()
        {
            return _bookName;
        }
        public void Input(string bkName)
        {
            _bookName = bkName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book objBook = new Book();
            objBook.Input("C#-The Complete Reference");
            Console.WriteLine(objBook.Print());
            Console.ReadKey();
        }
    }
}