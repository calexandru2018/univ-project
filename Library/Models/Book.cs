using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Library.Models {
    public class Book {

        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int BookAuthorId { get; set; }
        public virtual Author BookAuthor { get; set; }
        public virtual List<BookCopy> BookCopies { get; set; }

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
            return String.Format($"[{Id}] Author[{BookAuthorId}] -- {Title}");
        }
    }
}