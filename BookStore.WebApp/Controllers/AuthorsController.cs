using BookStore.Core.Entities;
using BookStore.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.WebApp.Controllers
{
    public class AuthorsController : Controller
    {
        // GET: Authors
        public ActionResult Index()
        {
            BookStoreClient lc = new BookStoreClient();
            ViewBag.listAuthors = lc.GetAllAuthors();
            return View();
        }

        // GET: Authors/Create
        public ActionResult Create()
        {
            BookStoreClient lc = new BookStoreClient();
            ViewBag.listEmploymentStatus = lc.GetEmplyeeStatusIdNameMVCModel().Select(x => new SelectListItem { Value = x.NAME, Text = x.NAME });
            return View("Create");
        }

        // POST: Authors/Create
        [HttpPost]
        public ActionResult Create(Author author)
        {
            BookStoreClient lc = new BookStoreClient();
            lc.CreateAuthor(author);
            return RedirectToAction("Index", "Authors");
        }

        // GET: Authors/Delete
        public ActionResult Delete(int id)
        {
            BookStoreClient lc = new BookStoreClient();
            lc.DeleteAuthr(id);
            return RedirectToAction("Index", "Authors");
        }

        // GET: Authors/Edit
        [HttpGet]
        public ActionResult Edit(int id)
        {
            BookStoreClient lc = new BookStoreClient();
            Author author = new Author();
            ViewBag.listEmploymentStatus = lc.GetEmplyeeStatusIdNameMVCModel().Select(x => new SelectListItem { Value = x.NAME, Text = x.NAME });
            author = lc.GetAuthor(id);

            return View("Edit", author);
        }

        // POST: Authors/Edit
        [HttpPost]
        public ActionResult Edit(Author author)
        {
            BookStoreClient pc = new BookStoreClient();
            pc.EditAuthor(author);
            return RedirectToAction("Index", "Authors");
        }
    }
}