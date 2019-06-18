using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCAppWithFormsAndParameters.Models;

namespace MVCAppWithFormsAndParameters.Controllers
{
    [Authorize]
    public class BooksController : Controller
    {
        private readonly ILogger _logger;
       // public BooksController(ILogger<BooksController> logger)
        public BooksController(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<BooksController>();
        }
        // GET: Books
        public ActionResult Index()
        {
            _logger.LogTrace("Index called");
            return View();
        }

        // GET: Books/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Books/Create
        [AllowAnonymous]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Books/Create
        [HttpPost]
//        [ValidateAntiForgeryToken]
        public ActionResult Create(Book book)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return View();
            }
        }

        // GET: Books/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Books/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {

                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Books/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Books/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}