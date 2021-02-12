using System;
namespace FinalLibrary.Entities
{
    public class ReaderBook
    {
        public int ReaderBookId { get; set; }
        public Reader Reader { get; set; }
        public Book Book { get; set; }
        public BookState BookState { get; set; } = BookState.New;
        public float Score { get; set; }
    }
}
