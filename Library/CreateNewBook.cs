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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class CreateNewBook : Form
    {

        BookService bookService;
        AuthorService authorService;

        /// <summary>
        /// Form constructor.
        /// </summary>
        /// <param name="auths"></param>
        /// <param name="bs"></param>
        public CreateNewBook(AuthorService auths, BookService bs)
        {
            authorService = auths;
            bookService = bs;
           
            InitializeComponent();

            authorService.Updated += AuthorService_Updated;
            ShowAllAuthors(authorService.All());
        }

        private void AuthorService_Updated(object sender, EventArgs e)
        {
            ShowAllAuthors(authorService.All());
        }

        private void ShowAllAuthors(IEnumerable<Author> authors)
        {
            lbAuthor.Items.Clear();
            foreach (Author author in authors)
            {
                lbAuthor.Items.Add(author);
            }
        }

        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Button to create a new book
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateNewBook_Click(object sender, EventArgs e)
        {
            Author addNewAuthor;
            if (chckAddNewAuthor.Checked == false)
            {
                addNewAuthor = lbAuthor.SelectedItem as Author;
                Debug.WriteLine(addNewAuthor);
            }
            else
            {
                addNewAuthor = new Author(txtAuthorName.Text);
                authorService.Add(addNewAuthor);
            }

            try
            {
                Regex rx = new Regex(@"^[0-9]{10,13}$");
                if (rx.Match(txtBookISBN.Text).Success)
                {
                    Book newBook = new Book()
                    {
                        ISBN = txtBookISBN.Text,
                        Title = txtBookTitle.Text,
                        Description = txtBookDesc.Text,
                        BookAuthor = addNewAuthor
                    };
                    bookService.Add(newBook);
                    MessageBox.Show("Book added");
                }
                else
                {
                    MessageBox.Show("Invalid ISBN");
                }
                
            }
            catch (Exception exp)
            {
                MessageBox.Show("Unable to add, make sure you selected an author.");
                Debug.WriteLine(exp);
            }
        }

        /// <summary>
        /// Checkbox that enbales the authors filedname (if new author is to be added)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chckAddNewAuthor_CheckedChanged(object sender, EventArgs e)
        {
            if (chckAddNewAuthor.Checked)
            {
                txtAuthorName.Enabled = true;
            }
            else
            {
                txtAuthorName.Enabled = false;
            }
        }

        /// <summary>
        /// Methods that checks if the "Add New Book" can be enabled or not.
        /// </summary>
        private void EnableAddNewBookBtn()
        {
            if (chckAddNewAuthor.Checked)
            {
                btnCreateNewBook.Enabled = (txtBookISBN.Text.Trim() != "" && txtBookTitle.Text.Trim() != "" && txtBookDesc.Text.Trim() != "" && txtAuthorName.Text.Trim() != "");
            }
            else
            {
                btnCreateNewBook.Enabled = (txtBookISBN.Text.Trim() != "" && txtBookTitle.Text.Trim() != "" && txtBookDesc.Text.Trim() != "" && lbAuthor.SelectedItem != null);
            }
        }

        /// <summary>
        /// Whenever the value changes, it should call EnableAddNewBookBtn() 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBookISBN_TextChanged(object sender, EventArgs e)
        {
            EnableAddNewBookBtn();
        }

        /// <summary>
        /// Whenever the value changes, it should call EnableAddNewBookBtn() 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBookTitle_TextChanged(object sender, EventArgs e)
        {
            EnableAddNewBookBtn();
        }

        /// <summary>
        /// Whenever the value changes, it should call EnableAddNewBookBtn() 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBookDesc_TextChanged(object sender, EventArgs e)
        {
            EnableAddNewBookBtn();
        }

        /// <summary>
        /// Whenever the value changes, it should call EnableAddNewBookBtn() 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAuthorName_TextChanged(object sender, EventArgs e)
        {
            EnableAddNewBookBtn();
        }

        /// <summary>
        /// Whenever the value changes, it should call EnableAddNewBookBtn() 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableAddNewBookBtn();
        }

        private void CreateNewBook_Load(object sender, EventArgs e)
        {

        }
    }
}
