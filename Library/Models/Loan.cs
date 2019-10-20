using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Loan
    {
        public int Id { get; set; }
        //public DateTime StartLoanTime { get; set; }
        public string StartLoanTimestamp { get; set; }
        //public DateTime DueDate { get; set; }
        public string DueDate { get; set; }
        public DateTime? ReturnLoanTimestamp { get; set; }
        public BookCopy LoanCopy { get; set; }
        public Member LibMember { get; set; }

        public Loan()
        {
           
        }

        public Loan(BookCopy bookCopy, Member member)
        {
            LoanCopy = bookCopy;
            LibMember = member;
            StartLoanTimestamp = "StartTimeStamp";
            DueDate = "+15days";
        }

        /// <summary>
        /// Useful for adding the book objects directly to a ListBox.
        /// </summary>
        public override string ToString()
        {
            return String.Format($"[{this.Id}] {StartLoanTimestamp} - {DueDate}; Returned: [{this.ReturnLoanTimestamp}]; Book: {LoanCopy.BookObject.Title}; Member: {LibMember.Name}");
        }
    }
}
