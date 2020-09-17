using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Mathletes2020.Areas.Multiplication.Controllers
{
    public partial class MultiplicationController : Controller
    {
        public IActionResult Times6()
        {
            var model = _answers.GetAnswers(6);
            ViewData["Answers"] = model;
            return View();
        }
    }
}
