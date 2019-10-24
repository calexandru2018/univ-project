using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public class BookService : IService
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
            OnUpdated();
        }

        /// <summary>
        /// return all books
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Book> All()
        {
            return bookRepository.All().OrderByDescending(book => book.Id);
        }

        /// <summary>
        /// returns all books by user providade author name
        /// </summary>
        /// <param name="author"></param>
        /// <returns></returns>
        public IEnumerable<Book> GetAllByAuthor(Author author)
        {
            return bookRepository.All().Where(b => b.BookAuthorId == author.Id);
        } 

        /// <summary>
        /// returns books that contain a certain pattern in their title
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public IEnumerable<Book> GetAllThatContainsInTitle(string a)
        {
            return bookRepository.All().Where(b => b.Title.ToLower().Contains(a.ToLower()));
        }

        /// <summary>
        /// The Edit method makes sure that the given Book object is saved to the database and raises the Updated() event.
        /// </summary>
        /// <param name="book"></param>
        public void Edit(Book book)
        {
            bookRepository.Edit(book);
            OnUpdated();
        }

        private void OnUpdated()
        {
            Updated?.Invoke(this, EventArgs.Empty);
        }
    }
}
