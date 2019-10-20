using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models {
    public class Book {

        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Author BookAuthor { get; set; }
        public List<BookCopy> BookCopies { get; set; }

        public Book()
        {
            BookCopies = new List<BookCopy>();
        }

        public Book(string isbn, string title, string description, Author author)
        {
            ISBN = isbn;
            title = Title;
            Description = description;
            BookAuthor = new Author();
            BookCopies = new List<BookCopy>();
        }

        /// <summary>
        /// Useful for adding the book objects directly to a ListBox.
        /// </summary>
        public override string ToString() {
            return String.Format($"[{this.Id}] -- {this.Title}");
        }
    }
}