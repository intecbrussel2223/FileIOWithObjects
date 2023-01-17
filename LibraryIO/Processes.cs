using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryIO
{
    public class Processes
    {
        public static void WriteToFile(List<Book> books, string path)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                for (int i = 0; i < books.Count; i++)
                {
                    sw.WriteLine(books[i].Title);
                    sw.WriteLine(books[i].Author);
                    sw.WriteLine(books[i].YearPublished);
                }
            }
        }

        public static List<Book> ReadFromFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                List<Book> lines = new List<Book>();
                while(!sr.EndOfStream) 
                { 
                    //volgorde super belangrijk

                    Book b = new Book();
                    b.Title = sr.ReadLine();
                    b.Author = sr.ReadLine();
                    b.YearPublished = int.Parse(sr.ReadLine());
                    lines.Add(b);
                }
                return lines;
            }
        }
        public static List<Book> PopulateBooks()
        {
            List<Book> books = new List<Book>();
            books.Add(new Book { Author = "Kenan", Title = "Title1", YearPublished = 2010 });
            books.Add(new Book { Author = "Rufat", Title = "Title2", YearPublished = 2000 });
            books.Add(new Book { Author = "Madalina", Title = "Title3", YearPublished = 2003 });
            books.Add(new Book { Author = "Sabrina", Title = "Title4", YearPublished = 2008 });
            books.Add(new Book { Author = "Jonas", Title = "Title5", YearPublished = 2015 });
            return books;
        }
    }
}
