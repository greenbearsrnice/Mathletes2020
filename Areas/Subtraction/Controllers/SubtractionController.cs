using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mathletes2020.Areas.Subtraction.Controllers
{
    [Area("Subtraction")]
    public class SubtractionController : Controller
    {
        // GET: SubtractionController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SubtractionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SubtractionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SubtractionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SubtractionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SubtractionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SubtractionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SubtractionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
