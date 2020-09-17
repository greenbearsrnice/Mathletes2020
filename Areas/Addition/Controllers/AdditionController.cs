using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mathletes2020.Areas.Addition.Controllers
{
    [Area("Addition")]
    public class AdditionController : Controller
    {
        // GET: AdditionController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AdditionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdditionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdditionController/Create
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

        // GET: AdditionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdditionController/Edit/5
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

        // GET: AdditionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdditionController/Delete/5
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
