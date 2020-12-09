using Microsoft.AspNetCore.Mvc;
using SampleWebAppWithViews.DTOs.Book;
using SampleWebAppWithViews.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleWebAppWithViews.Const;
using SampleWebAppWithViews.Models;

namespace SampleWebAppWithViews.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }
        public async Task<ActionResult<ReadBookDto>> Index()
        {
            var books = await _bookService.GetBooks();

            return View(books);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateBookDto request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            var response = await _bookService.CreateBook(request);

            await _bookService.SaveChangesAsync();

            return RedirectToAction("Index");

        }
    }
}

