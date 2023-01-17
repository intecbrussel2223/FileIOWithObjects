using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryIO
{
    public class Book//:IComparable<Book>
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }

        //public int CompareTo(Book other)
        //{
        //    return YearPublished.CompareTo(other.YearPublished);
        //}

        public override string ToString()
        {
            return $"{Title} {Author} {YearPublished}";
        }
    }
}
