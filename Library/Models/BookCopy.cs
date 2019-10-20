using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class BookCopy
    {
        public int Id { get; set; }
        public Book BookObject { get; set; }
        public int Condition{ get; set; }

        public BookCopy()
        {
 
        }
        public BookCopy(Book book, int condition)
        {
            BookObject = book;
            Condition = condition;
        }

        /// <summary>
        /// Useful for adding the book copies objects directly to a ListBox.
        /// </summary>
        public override string ToString()
        {
            return String.Format($"[{this.Id}] -- {BookObject.Title}; Condiditon: {this.Condition}");
        }
    }
}
