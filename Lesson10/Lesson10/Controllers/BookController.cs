using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lesson10.Data;
using Lesson10.Models;

namespace Lesson10.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository dataContext;

        public BookController(IBookRepository context)
        {
            dataContext = context;
        }

        // GET: Book
        public async Task<IActionResult> Index()
        {
            return View(await dataContext.GetBookList());
        }

        // GET: Book/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = dataContext.GetBookById(id.Value);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // GET: Book/Create
        public IActionResult Create()
        {
            ViewData["AuthorId"] = new SelectList(dataContext.GetAuthorList(), "AuthorId", "Name");
            return View();
        }

        // POST: Book/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("BookId,Title,Description,PublishedOn,AuthorId")] Book book)
        {
            if (ModelState.IsValid)
            {
                dataContext.SaveBook(book);
                return RedirectToAction(nameof(Index));
            }
            ViewData["AuthorId"] = new SelectList(dataContext.GetAuthorList(), "AuthorId", "Name", book.AuthorId);
            return View(book);
        }

        // GET: Book/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = dataContext.GetBookById(id.Value);
            if (book == null)
            {
                return NotFound();
            }
            ViewData["AuthorId"] = new SelectList(dataContext.GetAuthorList(), "AuthorId", "Name", book.AuthorId);
            return View(book);
        }

        // POST: Book/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("BookId,Title,Description,PublishedOn,AuthorId")] Book book)
        {
            if (id != book.BookId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    dataContext.SaveBook(book);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!dataContext.BookExists(book.BookId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["AuthorId"] = new SelectList(dataContext.GetAuthorList(), "AuthorId", "Name", book.AuthorId);
            return View(book);
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = dataContext.GetBookById(id.Value);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: Book/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            dataContext.DeleteBook(id);
            return RedirectToAction(nameof(Index));
        }

        private bool BookExists(int id)
        {
            return dataContext.BookExists(id);
        }
    }
}