using Library.Models;
using Library.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class CreateNewLoan : Form
    {

        private MemberService memberService;
        private LoanService loanService;
        private BookCopyService bookCopyService;
        private int memberId;

        public CreateNewLoan(MemberService ms, LoanService ls, int mId, BookCopyService bk)
        {
            memberService = ms;
            loanService = ls;
            bookCopyService = bk;
            memberId = mId;
            this.bookCopyService.Updated += BookCopyService_Updated;
            InitializeComponent();

            ShowAvailableCopies(bookCopyService.AllAvailable());
        }

        private void BookCopyService_Updated(object sender, EventArgs e)
        {
            ShowAvailableCopies(bookCopyService.AllAvailable());
        }

        private void ShowAvailableCopies(IEnumerable<BookCopy> bookCopies)
        {
            lbAvailCopies.Items.Clear();
            foreach (BookCopy bookCopy in bookCopies)
            {
                lbAvailCopies.Items.Add(bookCopy);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                BookCopy bookCopy = lbAvailCopies.SelectedItem as BookCopy;
                Member member = FindMemberBiId(memberId);
                //Loan newbookLoan = new Loan(bookCopy, member);
                Random rnd = new Random();
                int daysDiff = rnd.Next(-20, 30);
                Loan newbookLoan = new Loan(bookCopy, member, DateTime.Today.AddDays(daysDiff));

                member.LoanList.Add(newbookLoan);
                memberService.Edit(member);
            }
            catch
            {
                MessageBox.Show("Unable to load book");
            }
        }

        private Member FindMemberBiId(int memberId)
        {
            //memberService.
            throw new NotImplementedException();
        }


        private void CreateNewLoan_Load(object sender, EventArgs e)
        {

        }
    }
}
