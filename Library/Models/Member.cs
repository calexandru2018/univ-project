using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string SocialNumber { get; set; }
        public string Name { get; set; }
        //public DateTime MemberSince { get; set; }
        public string MemberSince { get; set; }
        public List<BookCopy> LoanList { get; set; }

        public Member()
        {
            LoanList = new List<BookCopy>();
        }
        public Member(string socialNumber, string name, string memberSince)
        {
            SocialNumber = socialNumber;
            Name = name;
            MemberSince = memberSince;
            LoanList = new List<BookCopy>();
        }

        /// <summary>
        /// Useful for adding the member object directly to a ListBox.
        /// </summary>
        public override string ToString()
        {
            return String.Format($"{this.SocialNumber}, {this.Name} -- {this.MemberSince}");
        }
    }
}
