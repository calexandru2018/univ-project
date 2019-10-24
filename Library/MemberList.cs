using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            
            InitializeComponent();

            memberService.Updated += MemberService_Updated;
            loanService.Updated += LoanService_Updated;
            ShowAllMembers(memberService.All());
        }

        /// <summary>
        /// Event method that updates the listbox with a users loan history
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoanService_Updated(object sender, EventArgs e)
        {
            Member selectedMember = lbMembers.SelectedItem as Member;
            lbLoanHistory.Items.Clear();
            foreach (Loan loan in loanService.AllMemberLoans(selectedMember))
            {
                lbLoanHistory.Items.Add(loan);
            }
        }

        /// <summary>
        /// Event method that update calls for the ShowAllMembers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Loads a loan history based on the selected user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Invokes a new form to create a loan based on the selected member
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Invokes a new form to create a member
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateMember_Click(object sender, EventArgs e)
        {
            CreateNewMember formCreateNewMember = new CreateNewMember(memberService);
            formCreateNewMember.ShowDialog();
        }

        /// <summary>
        /// Removes a member from the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Member selectedMember = lbMembers.SelectedItem as Member;
                var confirm = MessageBox.Show($"Do you really want to remove {selectedMember.Name}", "Remove member from System", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    memberService.Remove(selectedMember);
                }
            }
            catch
            {
                MessageBox.Show("Unable to remove user.");
            }
        }

        /// <summary>
        /// Closes form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Button to return the loan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturnLoan_Click(object sender, EventArgs e)
        {
            try
            {
                Loan selectedLoan = lbLoanHistory.SelectedItem as Loan;
                DateTime returnDate = dpReturnDate.Value.Date;

                selectedLoan.ReturnLoanTimestamp = returnDate;
                int dayDiff = (int)(returnDate - selectedLoan.DueDate).TotalDays;
                int fee = dayDiff * 10;

                var message = fee <= 0 ? $"Thank {selectedLoan.member.Name} for the return." : $"The fee for {selectedLoan.member.Name} with {dayDiff} day(s) is {fee}:-";

                loanService.Edit(selectedLoan);
                MessageBox.Show(message);
            }
            catch(Exception exp)
            {
                MessageBox.Show("Unable to return load, contact support.");
                Debug.WriteLine(exp);
            }
        }

        /// <summary>
        /// Enables the return loan button and datepicker so that a loan can be returned
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbLoanHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbLoanHistory.SelectedIndex >= 0)
            {
                btnReturnLoan.Enabled = true;
                dpReturnDate.Enabled = true;
            }
            else
            {
                btnReturnLoan.Enabled = false;
                dpReturnDate.Enabled = false;
            }
        }

        /// <summary>
        /// Button that calls the FindMemberBy method and applies the filter provided by the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilterBy_Click(object sender, EventArgs e)
        {

            if (cbFilterBy.SelectedIndex >= 0)
            {
                if(txtFilterBy.Text.Trim() != "")
                {
                    FindMembersBy(cbFilterBy.SelectedIndex, txtFilterBy.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Please provide input.");
                }
            }
            else
            {
                MessageBox.Show("Please select the search criteria.");
            }
        }

        /// <summary>
        /// Finds member(s) based on 4 criteria:
        /// Listbox:
        ///     0 - MemberID
        ///     1 - Member Name
        ///     2 - Social Number
        /// And user text input.
        /// </summary>
        /// <param name="userChoice"></param>
        /// <param name="userArg"></param>
        private void FindMembersBy(int userChoice, string userArg)
        {
            try
            {
                switch (userChoice)
                {
                    case 0:
                        int _userArgId = Convert.ToInt32(userArg);
                        ShowAllMembers(memberService.FindMembersBy(member => member.Id == _userArgId));
                        break;
                    case 1:
                        ShowAllMembers(memberService.FindMembersBy(member => member.Name.ToLower().Contains(userArg.ToLower())));
                        break;
                    case 2:
                        ShowAllMembers(memberService.FindMembersBy(member => member.SocialNumber.Contains(userArg)));
                        break;
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show("There was an issue searching in members, perhaps you entered an incorrect input value ?");
                Debug.WriteLine(exp);
            }
        }

        /// <summary>
        /// Enables buttons if the index changes to correct values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbMembers.SelectedIndex >= 0)
            {
                button1.Enabled = true;
                btnNewLoan.Enabled = true;
                btnShowLoanHistory.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                btnNewLoan.Enabled = false;
                btnShowLoanHistory.Enabled = false;
            }
        }

        /// <summary>
        /// Deselects the members list and restores the buttons to their original state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            lbMembers.ClearSelected();
            ShowAllMembers(memberService.All());
        }

        private void MemberList_Load(object sender, EventArgs e)
        {

        }
    }
}
