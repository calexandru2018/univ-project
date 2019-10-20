using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models {
    /// <summary>
    /// Database strategy is chosen as the base class to LibraryDbInit.
    /// Here in the Seed method you can create the default objects you want in the database.
    /// </summary>
    class LibraryDbInit : DropCreateDatabaseAlways<LibraryContext> {
        protected override void Seed(LibraryContext context) {
            base.Seed(context);

            Author author1 = new Author()
            {
                Name = "John Dewey"
            };

            Author author2 = new Author()
            {
                Name = "Isaac Newton"
            };

            Author author3 = new Author()
            {
                Name = "Stephen Hawking"
            };

            Author author4 = new Author()
            {
                Name = "Elon Musk"
            };

            Book book1 = new Book() {
                ISBN = "1234566",
                Title = "The Count of Monte Cristo",
                Description = "My first book",
                BookAuthor = author1
            };
            Book book2 = new Book() {
                ISBN = "09812314",
                Title = "The Gravity",
                Description = "Book about gravity",
                BookAuthor = author2
            };
            Book book3 = new Book() {
                ISBN = "345231234",
                Title = "The Deep Universe",
                Description = "A book about the universe and black holes.",
                BookAuthor = author3
            };
            Book book4 = new Book() {
                ISBN = "3453451",
                Title = "Robots Or Aliens ?",
                Description = "A book about AI.",
                BookAuthor = author4
            };

            // Add books to the Author
            author1.BooksWritten.Add(book1);
            author2.BooksWritten.Add(book2);
            author3.BooksWritten.Add(book3);
            author4.BooksWritten.Add(book4);

            // Add the author to the DbSet of authors.
            context.Authors.Add(author1);
            context.Authors.Add(author2);
            context.Authors.Add(author3);
            context.Authors.Add(author4);
            
            // Add the book to the DbSet of books.
            context.Books.Add(book1);
            context.Books.Add(book2);
            context.Books.Add(book3);
            context.Books.Add(book4);

            // Persist changes to the database
            context.SaveChanges();
        }
    }
}
