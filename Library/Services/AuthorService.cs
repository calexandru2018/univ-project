using System;
using System.Collections.Generic;
using Library.Repositories;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Services
{
    class AuthorService
    {
        AuthorRepository authorRepository;

        public AuthorService(RepositoryFactory rFactory)
        {
            this.authorRepository = rFactory.CreateAuthorRepository();
        }

        public IEnumerable<Author> All()
        {
            return authorRepository.All();
        }

        // Space to create custom functions to search, edit, delete authors

        public void Edit(Author a)
        {
            authorRepository.Edit(a);
        }
    }
}
