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
        public Book book{ get; set; }
        public int Condition{ get; set; }

        /// <summary>
        /// Useful for adding the book copies objects directly to a ListBox.
        /// </summary>
        public override string ToString()
        {
            return String.Format($"[{this.Id}] -- {this.Condition}");
        }
    }
}
