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

            // Author instantiation
            Author author1 = new Author("John Dewey");
            Author author2 = new Author("Isaac Newton");
            Author author3 = new Author("Stephen Hawking");
            Author author4 = new Author("Elon Musk");

            // Book instantiation
            Book book1 = new Book()
            {
                ISBN = "1234566",
                Title = "The Count of Monte Cristo",
                Description = "My first book",
                BookAuthor =  author1
            };
            Book book2 = new Book()
            {
                ISBN = "09812314",
                Title = "The Gravity",
                Description = "Book about gravity",
                BookAuthor =  author2
            };
            Book book3 = new Book()
            {
                ISBN = "345231234",
                Title = "The Deep Universe",
                Description = "A book about the universe and black holes.",
                BookAuthor =  author2
            };
            Book book4 = new Book()
            {
                ISBN = "3453451",
                Title = "Robots Or Aliens ? The quest",
                Description = "A book about AI.",
                BookAuthor =  author4
            };

            // Book Copy instantiation
            BookCopy book1Copy1 = new BookCopy(book1, 5);
            BookCopy book1Copy2 = new BookCopy(book1, 1);
            BookCopy book2Copy1 = new BookCopy(book2, 4);
            BookCopy book2Copy2 = new BookCopy(book2, 9);
            BookCopy book3Copy1 = new BookCopy(book3, 10);
            BookCopy book4Copy1 = new BookCopy(book4, 2);
            BookCopy book4Copy2 = new BookCopy(book4, 4);
            BookCopy book4Copy3 = new BookCopy(book4, 6);

            // Member instantiation
            Member member1 = new Member("900110-1002", "Sir Alex", DateTime.Parse("2015-10-4"));
            Member member2 = new Member("950109-9162", "Cristiano Rivaldo", DateTime.Parse("2010-12-10"));
            Member member3 = new Member("891020-9873", "Bill Cakes", DateTime.Parse("2012-09-02"));
            Member member4 = new Member("851224-2351", "Edward Billden", DateTime.Parse("2000-10-16"));

            // Loan instantiation
            Loan loan1 = new Loan(book1Copy1, member1);
            Loan loan2 = new Loan(book1Copy2, member2);
            Loan loan3 = new Loan(book2Copy1, member3);
            Loan loan4 = new Loan(book2Copy2, member3);
            Loan loan5 = new Loan(book3Copy1, member3);
            Loan loan6 = new Loan(book4Copy1, member4);
            Loan loan7 = new Loan(book4Copy2, member4);

            // Add books to the Author
            //author1.BooksWritten.Add(book1);
            //author2.BooksWritten.Add(book2);
            //author3.BooksWritten.Add(book3);
            //author4.BooksWritten.Add(book4);

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

            // Add members to the Dbset of members
            context.Members.Add(member1);
            context.Members.Add(member2);
            context.Members.Add(member3);
            context.Members.Add(member4);

            // Add loans to the Dbset of loans
            context.Loans.Add(loan1);
            context.Loans.Add(loan2);
            context.Loans.Add(loan3);
            context.Loans.Add(loan4);
            context.Loans.Add(loan5);
            context.Loans.Add(loan6);
            context.Loans.Add(loan7);

            // Persist changes to the database
            context.SaveChanges();
        }
    }
}
