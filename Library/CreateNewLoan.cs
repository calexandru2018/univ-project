﻿using Library.Models;
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

            InitializeComponent();

            bookCopyService.Updated += BookCopyService_Updated;
            memberService.Updated += MemberService_Updated;
            loanService.Updated += LoanService_Updated;
            ShowAvailableCopies(bookCopyService.AllAvailable());
        }

        private void LoanService_Updated(object sender, EventArgs e)
        {
            ShowAvailableCopies(bookCopyService.AllAvailable());
        }

        private void MemberService_Updated(object sender, EventArgs e)
        {
            ShowAvailableCopies(bookCopyService.AllAvailable());
        }

        private void BookCopyService_Updated(object sender, EventArgs e)
        {
            ShowAvailableCopies(bookCopyService.AllAvailable());
        }

        /// <summary>
        /// Shows all available copies
        /// </summary>
        /// <param name="bookCopies"></param>
        private void ShowAvailableCopies(IEnumerable<BookCopy> bookCopies)
        {
            lbAvailCopies.Items.Clear();
            foreach (BookCopy bookCopy in bookCopies)
            {
                lbAvailCopies.Items.Add(bookCopy);
                Debug.WriteLine("Inside loop create new look");
            }
            Debug.WriteLine("Rendering show all available copies inside create new");
        }

        /// <summary>
        /// Creates a new loan, based on the previously selected user from MemberList form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                BookCopy bookCopy = lbAvailCopies.SelectedItem as BookCopy;
                Member member = FindMemberBiId(memberId);
                Debug.WriteLine(member.Name);
                //Loan newbookLoan = new Loan(bookCopy, member);
                Random rnd = new Random();
                int daysDiff = rnd.Next(-20, 30);
                Loan newbookLoan = new Loan(bookCopy, member, DateTime.Today.AddDays(daysDiff))
                {
                    ReturnLoanTimestamp = null
                };
                member.LoanList.Add(newbookLoan);
                memberService.Edit(member);
            }
            catch(Exception exp)
            {
                MessageBox.Show("Unable to loan the book.");
                Debug.WriteLine(exp);
            }
        }

        /// <summary>
        /// Finds a member by ID
        /// </summary>
        /// <param name="memberId"></param>
        /// <returns></returns>
        private Member FindMemberBiId(int memberId)
        {
            return memberService.Find(memberId);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Button that calls for FindBookBy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilterBy_Click(object sender, EventArgs e)
        {
            int _cbFIlterBy = cbFilterBy.SelectedIndex;
            string _txtFilterBy = txtFilterBy.Text.Trim();
            if (_cbFIlterBy >= 0 && _txtFilterBy.Length > 0)
            {
                FindBookBy(_cbFIlterBy, _txtFilterBy);
            }
            else
            {
                MessageBox.Show("You need to choose a option and type in either the title or authors name.");
            }
        }

        /// <summary>
        /// Method that finds book copies based on 3 criteria
        /// Listbox:
        ///     0 - Book title
        ///     1 - Author name
        /// And user input
        /// </summary>
        /// <param name="searchOption"></param>
        /// <param name="searchTerm"></param>
        private void FindBookBy(int searchOption, string searchTerm)
        {
            IEnumerable<BookCopy> bookCopies = bookCopyService.FindBookByAuthor(searchTerm);

            if (searchOption == 0)
            {
                bookCopies = bookCopyService.FindBookByTitle(searchTerm);
            }
            if(bookCopies.Count() > 0)
            {
                lbAvailCopies.Items.Clear();
                foreach (BookCopy bk in bookCopies)
                {
                    lbAvailCopies.Items.Add(bk);
                }
            }
            else
            {
                MessageBox.Show("No such books were found");
            }
            
        } 

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateNewLoan_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Resets the search results 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            lbAvailCopies.ClearSelected();
            ShowAvailableCopies(bookCopyService.AllAvailable());
        }
    }
}
