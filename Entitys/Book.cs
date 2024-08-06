using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitys
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public int Year { get; set; }
        public int NumberOfCopies { get; set; }

        public Book(int bookID, string title, string author, string category, int year, int numberOfCopies)
        {
            BookID = bookID;
            Title = title;
            Author = author;
            Category = category;
            Year = year;
            NumberOfCopies = numberOfCopies;
        }

        public override string ToString()
        {
            return $"ID: {BookID}, Title: {Title}, Author: {Author}, Category: {Category}, Year: {Year}, Copies: {NumberOfCopies}";
        }
    }

}
