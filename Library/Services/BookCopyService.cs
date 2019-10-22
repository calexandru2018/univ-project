using System;
using System.Collections.Generic;
using Library.Repositories;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Services
{
    class BookCopyService : IService
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
            return bookCopyRepository.AllAvailable();
        }

        public IEnumerable<BookCopy> All()
        {
            return bookCopyRepository.All();
        }

        // Space to create custom functions to search, edit, delete authors

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
