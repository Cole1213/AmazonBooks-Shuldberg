namespace AmazonBooks_Shuldberg.Models
{
    public interface IBooksRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
