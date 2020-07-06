using System;
using SimpleLibrary.Data;

namespace SimpleLibrary.Core.Entities
{
    public class BookIssue:IEntity<int>
    {
        public int Id { get; set; }
        public int BorrowerId { get; set; }
        public Borrower Borrower { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public DateTime IssueDate { get; set; }
    }
}