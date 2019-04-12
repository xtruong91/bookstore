using BookStore.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.WebApp.Controllers
{
    public class BookWithAuthorController : Controller
    {
        // GET: BooksWithAuthors
        public ActionResult BookswithAuthors()
        {
            BookStoreClient bwu = new BookStoreClient();
            ViewBag.listBookswithAuthors = bwu.GetAllBookWithAuthors();
            return View();
        }
    }
}