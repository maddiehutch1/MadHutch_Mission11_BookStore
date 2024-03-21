namespace MadHutch_Mission11_BookStore.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
