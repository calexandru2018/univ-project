using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    class BookService : IService
    {
        /// <summary>
        /// service doesn't need a context but it needs a repository.
        /// </summary>
        BookRepository bookRepository;

        public event EventHandler Updated;

        /// <param name="rFactory">A repository factory, so the service can create its own repository.</param>
        public BookService(RepositoryFactory rFactory)
        {
            this.bookRepository = rFactory.CreateBookRepository();
        }

        public void Add(Book book)
        {
            bookRepository.Add(book);
        }

        public IEnumerable<Book> All()
        {
            return bookRepository.All();
        }

        public IEnumerable<Book> GetAllByAuthor(Author author)
        {
            return bookRepository.All().Where(b => b.BookAuthorId == author.Id);
        } 

        public IEnumerable<Book> GetAllThatContainsInTitle(string a)
        {
            return bookRepository.All().Where(b => b.Title.Contains(a));
        }

        /// <summary>
        /// The Edit method makes sure that the given Book object is saved to the database and raises the Updated() event.
        /// </summary>
        /// <param name="book"></param>
        public void Edit(Book book)
        {
            bookRepository.Edit(book);
            //Updated.Invoke(this, e);
            // TODO: Raise the Updated event.
        }
    }
}
