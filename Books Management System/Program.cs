using Entitys;

namespace Books_Management_System
{
    internal class Program
    {
        public static void Main()
        {
            LibrarySystem librarySystem = new LibrarySystem();

            while (true)
            {
                Console.WriteLine("\nLibrary Management System :) \n");
                Console.WriteLine("Books <><>");
                Console.WriteLine("1. Add Book           2. Update Book         3. Delete Book      4. List Books   \n");
                Console.WriteLine("Members @");
                Console.WriteLine("5. Register Member      6. Update Member        7. Delete Member      8. List Members \n");
                Console.WriteLine("Loans ~ ");
                Console.WriteLine("9. Issue Book         10. Return Book         11. List Loans\n");
                Console.WriteLine("12. Exit :( \n");
                Console.Write("Select an option: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("Enter title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter author: ");
                        string author = Console.ReadLine();
                        Console.Write("Enter category: ");
                        string category = Console.ReadLine();
                        Console.Write("Enter year: ");
                        int year = int.Parse(Console.ReadLine());
                        Console.Write("Enter number of copies: ");
                        int numberOfCopies = int.Parse(Console.ReadLine());
                        librarySystem.AddBook(title, author, category, year, numberOfCopies);
                        break;

                    case 2:
                        Console.Write("Enter book ID to update: ");
                        int bookID = int.Parse(Console.ReadLine());
                        Console.Write("Enter title: ");
                        string Booktitle = Console.ReadLine();
                        Console.Write("Enter author: ");
                        string Bookauthor = Console.ReadLine();
                        Console.Write("Enter category: ");
                        string Bcategory = Console.ReadLine();
                        Console.Write("Enter year: ");
                        int Byear = int.Parse(Console.ReadLine());
                        Console.Write("Enter number of copies: ");
                        int BnumberOfCopies = int.Parse(Console.ReadLine());
                        librarySystem.UpdateBook(bookID, Booktitle, Bookauthor,Bcategory,Byear,BnumberOfCopies);
                        break;

                    case 3:
                        Console.Write("Enter book ID to update: ");
                        int bookIDe = int.Parse(Console.ReadLine());
                        librarySystem.DeleteBook(bookIDe);
                        break;
                    
                    case 4:
                        librarySystem.ListBooks();
                        break;
                    case 5:
                        Console.Write("Enter a Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter an Address: ");
                        string address = Console.ReadLine();
                        Console.Write("Enter an Email: ");
                        string email = Console.ReadLine();
                        librarySystem.RegisterMember(name, address, email);
                        break;

                    case 6:
                        Console.Write("Enter a Member Id: ");
                        int memberId =int.Parse(Console.ReadLine());
                        Console.Write("Enter a Name: ");
                        string Mname = Console.ReadLine();
                        Console.Write("Enter an Address: ");
                        string Maddress = Console.ReadLine();
                        Console.Write("Enter an Email: ");
                        string Memail = Console.ReadLine();
                        librarySystem.UpdateMember(memberId,Mname, Maddress, Memail);
                        break;
                    case 7:
                        Console.Write("Enter a Member Id: ");
                        int Id = int.Parse(Console.ReadLine());
                        librarySystem.DeleteMember(Id);
                        break;
                    case 8:
                        librarySystem.ListMembers();
                        break;
                    case 9:
                        Console.Write("Enter a Book Id: ");
                        int bookId = int.Parse(Console.ReadLine());
                        Console.Write("Enter a Member Id: ");
                        int mid = int.Parse(Console.ReadLine());
                        librarySystem.IssueBook(bookId, mid);
                        break;
                    case 10:
                        Console.Write("Enter a Lian Id: ");
                        int loanId = int.Parse(Console.ReadLine());
                        librarySystem.ReturnBook(loanId);
                        break;
                    case 11:
                        librarySystem.ListLoans();
                        break;
                    case 12:
                        Console.ReadKey();
                        break;

                }
            }
        }
    }
}