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

            Author author1 = new Author("John Dewey");
            Author author2 = new Author("Isaac Newton");
            Author author3 = new Author("Stephen Hawking");
            Author author4 = new Author("Elon Musk");

            Book book1 = new Book("1234566", "The Count of Monte Cristo", "My first book", author1);
            Book book2 = new Book("09812314", "The Gravity", "Book about gravity", author2);
            Book book3 = new Book("345231234", "The Deep Universe", "A book about the universe and black holes.", author3);
            Book book4 = new Book("3453451", "Robots Or Aliens ?", "A book about AI.", author4);

            BookCopy book1Copy1 = new BookCopy(book1, 5);
            BookCopy book1Copy2 = new BookCopy(book1, 1);
            BookCopy book2Copy1 = new BookCopy(book2, 4);
            BookCopy book2Copy2 = new BookCopy(book2, 9);
            BookCopy book3Copy1 = new BookCopy(book3, 10);
            BookCopy book4Copy1 = new BookCopy(book4, 2);
            BookCopy book4Copy2 = new BookCopy(book4, 4);
            BookCopy book4Copy3 = new BookCopy(book4, 6);


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

            // Add the book copies to the Dbset of book copy.
            context.BookCopies.Add(book1Copy1);
            context.BookCopies.Add(book1Copy2);
            context.BookCopies.Add(book2Copy1);
            context.BookCopies.Add(book2Copy2);
            context.BookCopies.Add(book3Copy1);
            context.BookCopies.Add(book4Copy1);
            context.BookCopies.Add(book4Copy2);
            context.BookCopies.Add(book4Copy3);

            // Persist changes to the database
            context.SaveChanges();
        }
    }
}
