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

        public Author()
        {

        }

        public Author(string name)
        {
            Name = name;
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
