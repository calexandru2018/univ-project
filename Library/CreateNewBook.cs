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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private void CreateNewBook_Load(object sender, EventArgs e)
        {

        }

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
    }
}
