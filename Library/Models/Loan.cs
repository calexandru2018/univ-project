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

        public Loan(BookCopy bookCopy, Member member)
        {
            this.bookCopy = bookCopy;
            this.member = member;
            StartLoanTimestamp = DateTime.Now;
            DueDate = StartLoanTimestamp.AddDays(15);
        }

        /// <summary>
        /// Useful for adding the book objects directly to a ListBox.
        /// </summary>
        public override string ToString()
        {
            return String.Format($"[{this.Id}] {this.StartLoanTimestamp} - {this.DueDate}; ReturnedDate: [{this.ReturnLoanTimestamp}]; BookCopy[{this.BookCopyId}];MemberId {this.MemberId}");
        }
    }
}
