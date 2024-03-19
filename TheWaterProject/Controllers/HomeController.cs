using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TheWaterProject.Models;
using TheWaterProject.Models.ViewModels;

namespace TheWaterProject.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _repo;


        public HomeController(IBookRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index(int pageNum)
        {
            int PageSize = 10;
            var blah = new BookListViewModel
            {
                Books = _repo.Books
                .OrderBy(x => x.Title)
                .Skip((pageNum - 1) * PageSize)
                .Take(PageSize),

                PaginationInfo = new PaginationInfo
                {
                    Currentpage = pageNum,
                    ItemsPerPage = PageSize,
                    TotalItems = _repo.Books.Count()
                }
            };
            return View(blah);

        }
    }
}
