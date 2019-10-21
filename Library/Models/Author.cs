using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public List<Book> BooksWritten;

        public Author()
        {
            //BooksWritten = new List<Book>();
        }

        public Author(string name)
        {
            Name = name;
            //BooksWritten = new List<Book>();
        }

        /// <summary>
        /// Useful for adding the author objects directly to a ListBox.
        /// </summary>
        public override string ToString()
        {
            return String.Format($"[{this.Id}] -- {this.Name}");
        }
    }
}
