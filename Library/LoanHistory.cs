using Library.Models;
using Library.Services;
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

namespace Library
{
    public partial class LoanHistory : Form
    {
        LoanService loanService;

        public LoanHistory(LoanService ls)
        {
            loanService = ls;
            InitializeComponent();

            loanService.Updated += LoanService_Updated;
            ShowAllLoans(loanService.All());
        }

        private void LoanService_Updated(object sender, EventArgs e)
        {
            ShowAllLoans(loanService.All());
        }

        /// <summary>
        /// Calls the functions FindLoansBy that filerts the list based on the user input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilterBy_Click(object sender, EventArgs e)
        {

            if(cbFilterBy.SelectedIndex >= 0)
            {
                string _txtFilterBy = txtFilterBy.Text.Trim();
                if (_txtFilterBy.Length > 0)
                {
                    FindLoansBy(cbFilterBy.SelectedIndex, _txtFilterBy);
                }
                else
                {
                    MessageBox.Show("You need to type in something.");
                }
            }
            else
            {
                MessageBox.Show("You need to select the criteria of search.");
            }

        }

        private void ShowAllLoans(IEnumerable<Loan> loans)
        {
            lbLoanHistory.Items.Clear();
            foreach (Loan loan in loans)
            {
                lbLoanHistory.Items.Add(loan);
            }
        }

        /// <summary>
        /// Finds loans based on 5 criteria:
        /// Listbox:
        ///     0 - LoanID
        ///     1 - Condition
        ///     2 - Book Title
        ///     3 - MemberID
        ///     4 - Member Name
        /// And user text input.
        /// </summary>
        /// <param name="userChoice"></param>
        /// <param name="userArg"></param>
        private void FindLoansBy(int userChoice, string userArg)
        {
            try
            {
                switch (userChoice)
                {
                    case 0:
                        int _userArgId = Convert.ToInt32(userArg);
                        ShowAllLoans(loanService.FindLoansBy(loan=>loan.Id == _userArgId));
                        break;
                    case 1:
                        int _userArgCond = Convert.ToInt32(userArg);
                        ShowAllLoans(loanService.FindLoansBy(loan => loan.bookCopy.Condition == _userArgCond));
                        break;
                    case 2:
                        ShowAllLoans(loanService.FindLoansBy(loan => loan.bookCopy.BookObject.Title.Contains(userArg)));
                        break;
                    case 3:
                        int _userArgMemberId = Convert.ToInt32(userArg);
                        ShowAllLoans(loanService.FindLoansBy(loan => loan.MemberId == _userArgMemberId));
                        break;
                    case 4:
                        ShowAllLoans(loanService.FindLoansBy(loan => loan.member.Name.Contains(userArg)));
                        break;
                }
            }
            catch
            {
                MessageBox.Show("There was an issue searching for loans, perhaps incorrect input ?");
            }
        }

        private void btnNewLoan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoanHistory_Load(object sender, EventArgs e)
        {

        }
    }
}
