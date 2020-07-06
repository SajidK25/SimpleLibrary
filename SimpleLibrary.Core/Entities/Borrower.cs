using System.Collections.Generic;
using SimpleLibrary.Data;

namespace SimpleLibrary.Core.Entities
{
    public class Borrower:IEntity<int>
    {
        public int Id { get; set; }
        public string BorrowerName { get; set; }
        public decimal FineAmount { get; set; }
        public IList<BookIssue> BookIssues { get; set; }
        public IList<ReturnBook> ReturnBooks { get; set; }
    }
}