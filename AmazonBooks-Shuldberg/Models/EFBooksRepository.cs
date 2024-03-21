namespace AmazonBooks_Shuldberg.Models
{
    public class EFBooksRepository : IBooksRepository
    {
        public BookstoreContext _context;

        public EFBooksRepository(BookstoreContext temp)
        {
            _context = temp;
        }

        public IQueryable<Book> Books => _context.Books;
    }
}
