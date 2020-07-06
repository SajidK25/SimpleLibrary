using SimpleLibrary.Data;

namespace SimpleLibrary.Book.Entities
{
    public class Book : IEntity<int>
    {
        public int Id { get; set; }
    }
}