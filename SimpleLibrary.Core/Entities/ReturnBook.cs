using System;
using SimpleLibrary.Data;

namespace SimpleLibrary.Core.Entities
{
    public class ReturnBook:IEntity<int>
    {
        public int Id { get; set; }
        public int BorrowerId { get; set; }
        public Borrower Borrower { get; set; }
        public string Barcode { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}