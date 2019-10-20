using System;
using System.Collections.Generic;
using Library.Repositories;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Services
{
    class BookCopyService
    {
        BookCopyRepository bookCopyRepository;

        public BookCopyService(RepositoryFactory rFactory)
        {
            this.bookCopyRepository = rFactory.CreateBookCopyRepository();
        } 

        public IEnumerable<BookCopy> All()
        {
            return bookCopyRepository.All();
        }

        // Space to create custom functions to search, edit, delete authors

        public void Edit(BookCopy b)
        {
            bookCopyRepository.Edit(b);
            // TODO: Raise the Updated event.
        }
    }
}
