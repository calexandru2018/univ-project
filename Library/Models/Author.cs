using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Book> booksWritten { get; set; }

        /// <summary>
        /// Useful for adding the book objects directly to a ListBox.
        /// </summary>
        public override string ToString()
        {
            return String.Format("[{0}] -- {1}", this.Id, this.Name);
        }
    }
}
