using MadHutch_Mission11_BookStore.Models;
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

        public IActionResult Index()
        {
            var bookData = _bookRep.Books;

            return View(bookData);
        }
    }
}

   
