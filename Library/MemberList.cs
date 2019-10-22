using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Models;
using Library.Services;

namespace Library
{
    public partial class MemberList : Form
    {
        private MemberService memberService;
        private LoanService loanService;
        private BookCopyService bookCopyService;

        public MemberList(MemberService ms, LoanService ls, BookCopyService bk)
        {
            memberService = ms;
            loanService = ls;
            bookCopyService = bk;
            memberService.Updated += MemberService_Updated;
            loanService.Updated += LoanService_Updated;
            InitializeComponent();
            ShowAllMembers(memberService.All());
        }

        private void LoanService_Updated(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MemberService_Updated(object sender, EventArgs e)
        {
            ShowAllMembers(memberService.All());
        }

        private void ShowAllMembers(IEnumerable<Member> members)
        {
            lbMembers.Items.Clear();
            foreach (Member member in members)
            {
                lbMembers.Items.Add(member);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MemberList_Load(object sender, EventArgs e)
        {

        }

        private void btnShowLoanHistory_Click(object sender, EventArgs e)
        {
            try
            {
                Member selectedMember = lbMembers.SelectedItem as Member;
                lbLoanHistory.Items.Clear();
                foreach (Loan loan in loanService.AllMemberLoans(selectedMember))
                {
                    lbLoanHistory.Items.Add(loan);
                }
            }
            catch
            {
                MessageBox.Show("Select a member to show");
            }
        }

        private void btnFilterBy_Click(object sender, EventArgs e)
        {

        }

        private void btnNewLoan_Click(object sender, EventArgs e)
        {
            Member selectedMember = lbMembers.SelectedItem as Member;
            if (selectedMember != null)
            {
                CreateNewLoan formCreateNewLoan = new CreateNewLoan(memberService, loanService, selectedMember.Id, bookCopyService);
                formCreateNewLoan.ShowDialog();
            }
            else
            {
                MessageBox.Show("You need to select first a user");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateNewMember formCreateNewMember = new CreateNewMember(memberService);
            formCreateNewMember.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
