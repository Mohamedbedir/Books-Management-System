using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitys
{
    public class Librarian
    {
        public int LibrarianID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        private string Password { get; set; }

        public Librarian(int librarianID, string name, string email, string password)
        {
            LibrarianID = librarianID;
            Name = name;
            Email = email;
            Password = password;
        }

        public bool CheckPassword(string password)
        {
            return Password == password;
        }

        public override string ToString()
        {
            return $"ID: {LibrarianID}, Name: {Name}, Email: {Email}";
        }
    }

}
