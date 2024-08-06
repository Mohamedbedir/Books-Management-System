using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitys
{

    public class LibrarySystem
    {
        private List<Book> books = new List<Book>();
        private List<Member> members = new List<Member>();
        private List<Librarian> librarians = new List<Librarian>();
        private List<Loan> loans = new List<Loan>();
        private int nextBookID = 1;
        private int nextMemberID = 1;
        private int nextLoanID = 1;

        public void AddBook(string title, string author, string category, int year, int numberOfCopies)
        {
            books.Add(new Book(nextBookID++, title, author, category, year, numberOfCopies));
            Console.WriteLine("Book added successfully.");
        }

        public void UpdateBook(int bookID, string title, string author, string category, int year, int numberOfCopies)
        {
            Book book = books.Find(b => b.BookID == bookID);
            if (book != null)
            {
                book.Title = title;
                book.Author = author;
                book.Category = category;
                book.Year = year;
                book.NumberOfCopies = numberOfCopies;
                Console.WriteLine("Book updated successfully.");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        public void DeleteBook(int bookID)
        {
            Book book = books.Find(b => b.BookID == bookID);
            if (book != null)
            {
                books.Remove(book);
                Console.WriteLine("Book deleted successfully.");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        public void ListBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
        }

        public void RegisterMember(string name, string address, string email)
        {
            members.Add(new Member(nextMemberID++, name, address, email));
            Console.WriteLine("Member registered successfully.");
        }

        public void UpdateMember(int memberID, string name, string address, string email)
        {
            Member member = members.Find(m => m.MemberID == memberID);
            if (member != null)
            {
                member.Name = name;
                member.Address = address;
                member.Email = email;
                Console.WriteLine("Member updated successfully.");
            }
            else
            {
                Console.WriteLine("Member not found.");
            }
        }

        public void DeleteMember(int memberID)
        {
            Member member = members.Find(m => m.MemberID == memberID);
            if (member != null)
            {
                members.Remove(member);
                Console.WriteLine("Member deleted successfully.");
            }
            else
            {
                Console.WriteLine("Member not found.");
            }
        }

        public void ListMembers()
        {
            foreach (Member member in members)
            {
                Console.WriteLine(member);
            }
        }

        public void IssueBook(int bookID, int memberID)
        {
            Book book = books.Find(b => b.BookID == bookID);
            Member member = members.Find(m => m.MemberID == memberID);
            if (book != null && member != null && book.NumberOfCopies > 0)
            {
                loans.Add(new Loan(nextLoanID++, bookID, memberID, DateTime.Now, DateTime.Now.AddDays(14)));
                book.NumberOfCopies--;
                Console.WriteLine("Book issued successfully.");
            }
            else
            {
                Console.WriteLine("Book issuing failed. Either book or member not found, or no copies available.");
            }
        }

        public void ReturnBook(int loanID)
        {
            Loan loan = loans.Find(l => l.LoanID == loanID);
            if (loan != null)
            {
                loan.ReturnBook();
                Book book = books.Find(b => b.BookID == loan.BookID);
                if (book != null)
                {
                    book.NumberOfCopies++;
                }
                Console.WriteLine("Book returned successfully.");
            }
            else
            {
                Console.WriteLine("Loan not found.");
            }
        }

        public void ListLoans()
        {
            foreach (Loan loan in loans)
            {
                Console.WriteLine(loan);
            }
        }
    }

}
