using LibraryIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static string path = @"c:\Temp\Books.txt";
        static void Main(string[] args)
        {
            List<Book> books= new List<Book>();
            books = Processes.PopulateBooks();

            Processes.WriteToFile(books, path);

            List<Book> list= new List<Book>();
            list = Processes.ReadFromFile(path);

            Console.WriteLine("Un sorted list of books");
            foreach (var book in list)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine("Sorted list");
            //list.Sort();
            List<Book> sortedList = list.OrderBy(b => b.Author).ToList();
            foreach (var book in sortedList)
            {
                Console.WriteLine(book);
            }
        }
    }
}
