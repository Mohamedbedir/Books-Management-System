using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitys
{
    public class Loan
    {
        public int LoanID { get; set; }
        public int BookID { get; set; }
        public int MemberID { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ExpectedReturnDate { get; set; }
        public DateTime? ActualReturnDate { get; set; }

        public Loan(int loanID, int bookID, int memberID, DateTime loanDate, DateTime expectedReturnDate)
        {
            LoanID = loanID;
            BookID = bookID;
            MemberID = memberID;
            LoanDate = loanDate;
            ExpectedReturnDate = expectedReturnDate;
            ActualReturnDate = null;
        }

        public void ReturnBook()
        {
            ActualReturnDate = DateTime.Now;
        }

        public override string ToString()
        {
            return $"LoanID: {LoanID}, BookID: {BookID}, MemberID: {MemberID}, LoanDate: {LoanDate}, ExpectedReturnDate: {ExpectedReturnDate}, ActualReturnDate: {(ActualReturnDate.HasValue ? ActualReturnDate.Value.ToString() : "Not Returned")}";
        }
    }

}
