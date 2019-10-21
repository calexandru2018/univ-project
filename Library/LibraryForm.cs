using Library.Models;
using Library.Repositories;
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
    public partial class LibraryForm : Form
    {

        BookService bookService;
        AuthorService authorService;
        BookCopyService bookCopyService;
        MemberService memberService;
        LoanService loanService;

        public LibraryForm()
        {
            InitializeComponent();

            // we create only one context in our application, which gets shared among repositories
            LibraryContext context = new LibraryContext();
            // we use a factory object that will create the repositories as they are needed, it also makes
            // sure all the repositories created use the same context.
            RepositoryFactory repFactory = new RepositoryFactory(context);

            this.bookService = new BookService(repFactory);
            this.authorService = new AuthorService(repFactory);
            this.bookCopyService = new BookCopyService(repFactory);
            this.memberService = new MemberService(repFactory);
            this.loanService = new LoanService(repFactory);

            ShowAllBooks(bookService.All());
            ShowAllAuthors(authorService.All());
            ShowAllBookCopies(bookCopyService.All());
            ShowAllMembers(memberService.All());
            ShowAllLoans(loanService.All());
            ShowAvailableCopies(bookCopyService.AllAvailable());
        }


        private void BTNChangeBook_Click(object sender, EventArgs e)
        {
            Book b = lbBooks.SelectedItem as Book;
            if (b != null)
            {
                b.Title = "Yoyoma koko";
                bookService.Edit(b);
                ShowAllBooks(bookService.All());
            }
        }

        // Show methods
        private void ShowAllLoans(IEnumerable<Loan> loans)
        {
            lbLoans.Items.Clear();
            foreach (Loan loan in loans)
            {
                lbLoans.Items.Add(loan);
            }
        }

        private void ShowAllMembers(IEnumerable<Member> members)
        {
            lbMembers.Items.Clear();
            foreach (Member member in members)
            {
                lbMembers.Items.Add(member);
            }
        }

        private void ShowAllBooks(IEnumerable<Book> books)
        {
            lbBooks.Items.Clear();
            foreach (Book book in books)
            {
                lbBooks.Items.Add(book);
            }
        }

        private void ShowAllAuthors(IEnumerable<Author> authors)
        {
            lbAuthors.Items.Clear();
            foreach (Author author in authors)
            {
                lbAuthors.Items.Add(author);
            }
        }

        private void ShowAllBookCopies(IEnumerable<BookCopy> bookCopies)
        {
            lbBookCopies.Items.Clear();
            foreach (BookCopy bookCopy in bookCopies)
            {
                lbBookCopies.Items.Add(bookCopy);
            }
        }

        private void ShowAvailableCopies(IEnumerable<BookCopy> bookCopies)
        {
            lbAvailCopies.Items.Clear();
            foreach (BookCopy bookCopy in bookCopies)
            {
                lbAvailCopies.Items.Add(bookCopy);
            }
            Debug.WriteLine("Rendering show all available copies");
        }

        // Add new books and authors
        private void addNewBook_Click_1(object sender, EventArgs e)
        {
            Author addNewAuthor;
            if (newAuthor.Checked == false)
            {
                addNewAuthor = lbAuthors.SelectedItem as Author;
                Debug.WriteLine(addNewAuthor);
            }
            else
            {
                addNewAuthor = new Author(addAuthorName.Text);
                authorService.Add(addNewAuthor);
            }
           
            Book newBook = new Book()
            {
                ISBN = addBookISBN.Text,
                Title = addBookTitle.Text,
                Description = addBookDesc.Text,
                BookAuthor = addNewAuthor
            };

            //addNewAuthor.BooksWritten.Add(newBook);

            
            bookService.Add(newBook);

            ShowAllBooks(bookService.All());
            ShowAllAuthors(authorService.All());
        }

        private void addNewMember_Click(object sender, EventArgs e)
        {
            Member newMember = new Member()
            {
                SocialNumber = addMemberSocialNum.Text,
                Name = addMemberName.Text,
                MemberSince = DateTime.Now
            };

            memberService.Add(newMember);

            ShowAllMembers(memberService.All());
        }

        private void newAuthor_CheckedChanged(object sender, EventArgs e)
        {
            if (newAuthor.Checked)
            {
                addAuthorName.Enabled = true;
            }
            else
            {
                addAuthorName.Enabled = false;
            }
        }

        private void addNewBookCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Book b = lbBooks.SelectedItem as Book;
                BookCopy bookCopy = new BookCopy(b, Convert.ToInt32(bookCopyCondition.Text));
                bookCopyService.Add(bookCopy);
                ShowAllBookCopies(bookCopyService.All());
                ShowAvailableCopies(bookCopyService.AllAvailable());
            }
            catch
            {
                MessageBox.Show("Need to choose a book");
            }
        }

        private void loanBook_Click(object sender, EventArgs e)
        {
            try
            {
                BookCopy bookCopy = lbAvailCopies.SelectedItem as BookCopy;
                Member member = lbMembers.SelectedItem as Member;
                //Loan newbookLoan = new Loan(bookCopy, member);
                Random rnd = new Random();
                int daysDiff = rnd.Next(-20, 30);
                Loan newbookLoan = new Loan(bookCopy, member, DateTime.Today.AddDays(daysDiff));

                member.LoanList.Add(newbookLoan);
                memberService.Edit(member);

                loanService.Add(newbookLoan);
                ShowAllLoans(loanService.All());
                ShowAvailableCopies(bookCopyService.AllAvailable());
            }
            catch
            {
                MessageBox.Show("Unable to load book");
            }
        }

        private void listByAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                Author searchAfter = lbAuthors.SelectedItem as Author;
                lbShowFilteredContent.Items.Clear();
                foreach (Book book in bookService.GetAllByAuthor(searchAfter))
                {
                    lbShowFilteredContent.Items.Add(book);
                }
            }
            catch
            {
                MessageBox.Show("You need to select an author");
            }
        }

        private void showUserHistory_Click(object sender, EventArgs e)
        {
            try
            {
                Member selectedMember = lbMembers.SelectedItem as Member;
                removeMember.Items.Clear();
                foreach (Loan loan in loanService.AllMemberLoans(selectedMember))
                {
                    removeMember.Items.Add(loan);
                }
            }
            catch
            {
                MessageBox.Show("Select a member to show");
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Loan selectedLoan = lbLoans.SelectedItem as Loan;
                DateTime returnDate = datePicker.Value.Date;

                selectedLoan.ReturnLoanTimestamp = returnDate;
                int dayDiff = (int)(returnDate - selectedLoan.DueDate).TotalDays;
                int fee = dayDiff * 10;

                var message = fee <= 0 ? $"Thank {selectedLoan.member.Name} for the return." : $"The fee for {selectedLoan.member.Name} with {dayDiff} day(s) is {fee}:-";

                loanService.Remove(selectedLoan);
                MessageBox.Show(message);
                ShowAvailableCopies(bookCopyService.AllAvailable());
                ShowAllLoans(loanService.All());
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void btnRemoveMember_Click(object sender, EventArgs e)
        {
            try
            {
                Member selectedMember = lbMembers.SelectedItem as Member;
                var confirm = MessageBox.Show($"Do you really want to remove {selectedMember.Name}","Remove member from System", MessageBoxButtons.YesNo);
                if(confirm == DialogResult.Yes)
                {
                    memberService.Remove(selectedMember);
                    ShowAllMembers(memberService.All());
                    ShowAllLoans(loanService.All());
                    ShowAvailableCopies(bookCopyService.AllAvailable());
                }
            }
            catch
            {
                MessageBox.Show("unable to remove user");
            }
        }
    }
}
