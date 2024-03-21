//using AmazonBooks_Shuldberg.Models;
using AmazonBooks_Shuldberg.Models;
using AmazonBooks_Shuldberg.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AmazonBooks_Shuldberg.Controllers
{
    public class HomeController : Controller
    {
        private IBooksRepository _repo;

        public HomeController(IBooksRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;

            var data = new BooksViewModel
            {
                Books = _repo.Books
                    .OrderBy(x => x.BookId)
                    .Skip(pageSize * (pageNum - 1))
                    .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Books.Count()
                }
            };

            return View(data);
        }

    }
}
