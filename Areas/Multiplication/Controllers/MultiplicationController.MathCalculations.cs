using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mathletes2020.Areas.Multiplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient.DataClassification;



namespace Mathletes2020.Areas.Multiplication.Controllers
{
    public partial class MultiplicationController : Controller
    {

        //private readonly IAnswersRepository _answers;

        //public MultiplicationController(IAnswersRepository answers)
        //{
        //    _answers = answers;
        //}
        public ActionResult MathCalculations(Responses responses)
        {
            
            return View(responses);
        }
    }
}
