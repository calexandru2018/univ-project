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

            // Service intialization
            this.bookService = new BookService(repFactory);
            this.authorService = new AuthorService(repFactory);
            this.bookCopyService = new BookCopyService(repFactory);
            this.memberService = new MemberService(repFactory);
            this.loanService = new LoanService(repFactory);

            // Event declaration
            this.bookService.Updated += BookService_Updated;
            this.authorService.Updated += AuthorService_Updated;
            this.memberService.Updated += MemberService_Updated;
            this.loanService.Updated += LoanService_Updated;
            this.bookCopyService.Updated += BookCopyService_Updated;

            // Start up methods that populate the lists
            ShowAllBooks(bookService.All());
            ShowAllAuthors(authorService.All());
            ShowAvailableCopies(bookCopyService.AllAvailable());
        }

        /// <summary>
        /// BookCopy service method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookCopyService_Updated(object sender, EventArgs e)
        {
            ShowAvailableCopies(bookCopyService.AllAvailable());
        }

        /// <summary>
        /// Loan service event method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoanService_Updated(object sender, EventArgs e)
        {
            ShowAvailableCopies(bookCopyService.AllAvailable());
        }

        /// <summary>
        /// Member service event method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MemberService_Updated(object sender, EventArgs e)
        {
            ShowAvailableCopies(bookCopyService.AllAvailable());
        }

        /// <summary>
        /// Author service event method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AuthorService_Updated(object sender, EventArgs e)
        {
            ShowAllAuthors(authorService.All());
        }

        /// <summary>
        /// Book service event method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookService_Updated(object sender, EventArgs e)
        {
            ShowAvailableCopies(bookCopyService.AllAvailable());
            ShowAllBooks(bookService.All());
        }

        /// <summary>
        /// Shows all books
        /// </summary>
        /// <param name="books"></param>
        private void ShowAllBooks(IEnumerable<Book> books)
        {
            lbBooks.Items.Clear();
            foreach (Book book in books)
            {
                lbBooks.Items.Add(book);
            }
        }

        /// <summary>
        /// Shows all authors
        /// </summary>
        /// <param name="authors"></param>
        private void ShowAllAuthors(IEnumerable<Author> authors)
        {
            lbAuthors.Items.Clear();
            foreach (Author author in authors)
            {
                lbAuthors.Items.Add(author);
            }
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
            }
        }

        /// <summary>
        /// Button that adds new book copies
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addNewBookCopy_Click(object sender, EventArgs e)
        {
            if(cbBookCondition.SelectedIndex >= 0 )
            {
                Book b = lbBooks.SelectedItem as Book;
                BookCopy bookCopy = new BookCopy(b, Convert.ToInt32(cbBookCondition.SelectedItem.ToString()));
                bookCopyService.Add(bookCopy);
                Debug.WriteLine($"Added new book, {bookCopy.BookObject.Title} condition {bookCopy.Condition}");
            }
            else
            {
                MessageBox.Show("You need to specify a condition");
            }
        }

        /// <summary>
        /// Filters books by selected author
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listByAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                Author searchAfter = lbAuthors.SelectedItem as Author;
                lbBooks.Items.Clear();
                foreach (Book book in bookService.GetAllByAuthor(searchAfter))
                {
                    lbBooks.Items.Add(book);
                }
            }
            catch
            {
                MessageBox.Show("You need to select an author");
            }
        }

        /// <summary>
        /// Shows list with Member/Loan Management
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            MemberList formMemberList = new MemberList(memberService, loanService, bookCopyService);
            formMemberList.ShowDialog();
        }

        /// <summary>
        /// Shows form to create/add new book
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            CreateNewBook formCreateNewBook = new CreateNewBook(authorService, bookService);
            formCreateNewBook.ShowDialog();
        }

        /// <summary>
        /// Shows form with Loan History
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            LoanHistory formLoanHistory = new LoanHistory(loanService);
            formLoanHistory.ShowDialog();
        }

        /// <summary>
        /// Clears the selected item in authors, resetting the list of books to default (shows all books) 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            lbAuthors.ClearSelected();
            addNewBookCopy.Enabled = false;
            cbBookCondition.Enabled = false;
            ShowAllBooks(bookService.All());
        }

        /// <summary>
        /// When the index changes, it should enable the button to search by author
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbAuthors.SelectedIndex >= 0)
            {
                btnByAuthor.Enabled = true;
            }
            else
            {
                btnByAuthor.Enabled = false;
            }
        }

        /// <summary>
        /// To close actual form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// When the book index changes, it should enablde buttons and combobox to add new copy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBooks.SelectedIndex >= 0 || lbBooks.SelectedItem != null)
            {
                addNewBookCopy.Enabled = true;
                cbBookCondition.Enabled = true;
            }
            else
            {
                addNewBookCopy.Enabled = false;
                cbBookCondition.Enabled = false;
            }
        }

        /// <summary>
        /// Don't ask me.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LibraryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
