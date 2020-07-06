using System.Collections.Generic;
using SimpleLibrary.Data;

namespace SimpleLibrary.Core.Entities
{
    public class Book : IEntity<int>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Edition { get; set; }
        public string Barcode { get; set; }
        public int CopyCount { get; set; }
        public IList<BookIssue> BookIssues { get; set; }
    }
}