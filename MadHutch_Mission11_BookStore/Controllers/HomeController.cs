using MadHutch_Mission11_BookStore.Models;
using MadHutch_Mission11_BookStore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MadHutch_Mission11_BookStore.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _bookRep;
        public HomeController(IBookRepository temp)
        {
            _bookRep = temp;
        } 

        public IActionResult Index(int pageNum)
        {
            int pageSize = 5;
            var thingy = new BooksListViewModel
            {
                Books = _bookRep.Books
                .OrderBy(x => x.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PaginationInfo = new PaginationInfo()
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _bookRep.Books.Count()
                }
            };

            return View(thingy);
        }
    }
}

   
