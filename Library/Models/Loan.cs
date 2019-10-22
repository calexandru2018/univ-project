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
        public DateTime StartLoanTimestamp { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnLoanTimestamp { get; set; }
        public int BookCopyId { get; set;}
        public virtual BookCopy bookCopy { get; set; }
        public int MemberId { get; set; }
        public virtual Member member { get; set; }

        public Loan()
        {
           
        }

        public Loan(BookCopy bookCopy, Member member, DateTime startloantime)
        {
            this.bookCopy = bookCopy;
            this.member = member;
            StartLoanTimestamp = startloantime;
            DueDate = StartLoanTimestamp.AddDays(15);
            //ReturnLoanTimestamp = returnLoan;
        }

        /// <summary>
        /// Useful for adding the book objects directly to a ListBox.
        /// </summary>
        public override string ToString()
        {
            string message = "In loan";
            if (this.DueDate < DateTime.Today && !ReturnLoanTimestamp.HasValue)
            {
                message = "Overdue";
            }
            else if(ReturnLoanTimestamp.HasValue)
            {
                message = "Returned";
            }
            return String.Format($"[{this.Id}] {this.StartLoanTimestamp} - Due:{this.DueDate}; ReturnedDate: [{this.ReturnLoanTimestamp}]; BookCopy: {this.bookCopy.BookObject?.Title};Member {this.member?.Name}; Status: {message}");
            //return String.Format($"[{this.Id}] Start{this.StartLoanTimestamp} - Due:{this.DueDate}; ReturnedDate: [{this.ReturnLoanTimestamp}]; Status: {message}; UserID: {this.MemberId}");
        }
    }
}
