using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Mathletes2020.Areas.Multiplication.Controllers
{
    [Area("Multiplication")]
    public partial class MultiplicationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
