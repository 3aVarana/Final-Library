using System;
using System.Collections.Generic;

namespace FinalLibrary.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string CompleteName { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
