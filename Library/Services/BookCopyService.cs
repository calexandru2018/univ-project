using System;
using System.Collections.Generic;
using Library.Repositories;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Services
{
    public class BookCopyService : IService
    {
        BookCopyRepository bookCopyRepository;

        public event EventHandler Updated;

        public BookCopyService(RepositoryFactory rFactory)
        {
            this.bookCopyRepository = rFactory.CreateBookCopyRepository();
        } 

        public void Add(BookCopy bookCopy)
        {
            bookCopyRepository.Add(bookCopy);
            OnUpdated();
        }

        public IEnumerable<BookCopy> AllAvailable()
        {
            return bookCopyRepository.AllAvailable().OrderBy(book => book.BookObject.Id);
        }

        public IEnumerable<BookCopy> All()
        {
            return bookCopyRepository.All().OrderBy(book => book.BookObject.Id);
        }

        public IEnumerable<BookCopy> FindBookByTitle(string title)
        {
            return bookCopyRepository.AllAvailable().Where(bookCopy => bookCopy.BookObject.Title.Contains(title));
        }

        public IEnumerable<BookCopy> FindBookByAuthor(string author)
        {
            return bookCopyRepository.AllAvailable().Where(bookCopy => bookCopy.BookObject.BookAuthor.Name.Contains(author));
        }

        public void Edit(BookCopy b)
        {
            bookCopyRepository.Edit(b);
            OnUpdated();
        }

        public void Remove(BookCopy item)
        {
            bookCopyRepository.Remove(item);
            OnUpdated();
        }

        private void OnUpdated()
        {
            Updated?.Invoke(this, EventArgs.Empty);
        }
    }
}
