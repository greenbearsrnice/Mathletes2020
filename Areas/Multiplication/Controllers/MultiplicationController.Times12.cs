﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Mathletes2020.Areas.Multiplication.Controllers
{
    public partial class MultiplicationController : Controller
    {
        public IActionResult Times12()
        {
            var model = _answers.GetAnswers(12);
            ViewData["Answers"] = model;
            return View();
        }
    }
}
