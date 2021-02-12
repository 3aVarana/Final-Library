using System;
using System.Collections.Generic;

namespace FinalLibrary.Entities
{
    public class Reader
    {
        public int ReaderId { get; set; }
        public string CompleteName { get; set; }
        public string Email { get; set; }

        public ICollection<ReaderBook> ReaderBooks { get; set; }
    }
}
