using System;
using System.Collections.Generic;

namespace FinalLibrary.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Editorial { get; set; }
        public DateTime PublishDate { get; set; } = DateTime.MinValue;

        public ICollection<Author> Authors { get; set; }
    }
}
