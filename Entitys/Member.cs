using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitys
{
    
    public class Member
    {
        public int MemberID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public Member(int memberID, string name, string address, string email)
        {
            MemberID = memberID;
            Name = name;
            Address = address;
            Email = email;
        }

        public override string ToString()
        {
            return $"ID: {MemberID}, Name: {Name}, Address: {Address}, Email: {Email}";
        }
    }

}
