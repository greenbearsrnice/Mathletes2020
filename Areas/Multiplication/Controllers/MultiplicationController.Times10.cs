using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mathletes2020.Areas.Multiplication.Models;

namespace Mathletes2020.Areas.Multiplication.Controllers
{
    public partial class MultiplicationController : Controller
    {
        [HttpGet]
        public ActionResult Times10()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Times10([FromForm] Responses responses)
        {
            var model = _answers.GetAnswers(10);
            var i = 0;
            ViewData["Answers"] = model;

            //Check answers
            if (responses.Tb1 == model.Ans1) { i = i + 1; }
            if (responses.Tb2 == model.Ans2) { i = i + 1; }
            if (responses.Tb3 == model.Ans3) { i = i + 1; }
            if (responses.Tb4 == model.Ans4) { i = i + 1; }
            if (responses.Tb5 == model.Ans5) { i = i + 1; }
            if (responses.Tb6 == model.Ans6) { i = i + 1; }
            if (responses.Tb7 == model.Ans7) { i = i + 1; }
            if (responses.Tb8 == model.Ans8) { i = i + 1; }
            if (responses.Tb9 == model.Ans9) { i = i + 1; }
            if (responses.Tb10 == model.Ans10) { i = i + 1; }

            if (responses.Tb11 == model.Ans11) { i = i + 1; }
            if (responses.Tb12 == model.Ans12) { i = i + 1; }
            if (responses.Tb13 == model.Ans13) { i = i + 1; }
            if (responses.Tb14 == model.Ans14) { i = i + 1; }
            if (responses.Tb15 == model.Ans15) { i = i + 1; }
            if (responses.Tb16 == model.Ans16) { i = i + 1; }
            if (responses.Tb17 == model.Ans17) { i = i + 1; }
            if (responses.Tb18 == model.Ans18) { i = i + 1; }
            if (responses.Tb19 == model.Ans19) { i = i + 1; }
            if (responses.Tb20 == model.Ans20) { i = i + 1; }

            if (responses.Tb21 == model.Ans21) { i = i + 1; }
            if (responses.Tb22 == model.Ans22) { i = i + 1; }
            if (responses.Tb23 == model.Ans23) { i = i + 1; }
            if (responses.Tb24 == model.Ans24) { i = i + 1; }
            if (responses.Tb25 == model.Ans25) { i = i + 1; }
            if (responses.Tb26 == model.Ans26) { i = i + 1; }
            if (responses.Tb27 == model.Ans27) { i = i + 1; }
            if (responses.Tb28 == model.Ans28) { i = i + 1; }
            if (responses.Tb29 == model.Ans29) { i = i + 1; }
            if (responses.Tb30 == model.Ans30) { i = i + 1; }

            if (responses.Tb31 == model.Ans31) { i = i + 1; }
            if (responses.Tb32 == model.Ans32) { i = i + 1; }
            if (responses.Tb33 == model.Ans33) { i = i + 1; }
            if (responses.Tb34 == model.Ans34) { i = i + 1; }
            if (responses.Tb35 == model.Ans35) { i = i + 1; }
            if (responses.Tb36 == model.Ans36) { i = i + 1; }
            if (responses.Tb37 == model.Ans37) { i = i + 1; }
            if (responses.Tb38 == model.Ans38) { i = i + 1; }
            if (responses.Tb39 == model.Ans39) { i = i + 1; }
            if (responses.Tb40 == model.Ans40) { i = i + 1; }

            if (responses.Tb41 == model.Ans41) { i = i + 1; }
            if (responses.Tb42 == model.Ans42) { i = i + 1; }
            if (responses.Tb43 == model.Ans43) { i = i + 1; }
            if (responses.Tb44 == model.Ans44) { i = i + 1; }
            if (responses.Tb45 == model.Ans45) { i = i + 1; }
            if (responses.Tb46 == model.Ans46) { i = i + 1; }
            if (responses.Tb47 == model.Ans47) { i = i + 1; }
            if (responses.Tb48 == model.Ans48) { i = i + 1; }
            if (responses.Tb49 == model.Ans49) { i = i + 1; }
            if (responses.Tb50 == model.Ans50) { i = i + 1; }

            if (responses.Tb51 == model.Ans51) { i = i + 1; }
            if (responses.Tb52 == model.Ans52) { i = i + 1; }
            if (responses.Tb53 == model.Ans53) { i = i + 1; }
            if (responses.Tb54 == model.Ans54) { i = i + 1; }
            if (responses.Tb55 == model.Ans55) { i = i + 1; }
            if (responses.Tb56 == model.Ans56) { i = i + 1; }
            if (responses.Tb57 == model.Ans57) { i = i + 1; }
            if (responses.Tb58 == model.Ans58) { i = i + 1; }
            if (responses.Tb59 == model.Ans59) { i = i + 1; }
            if (responses.Tb60 == model.Ans60) { i = i + 1; }

            if (responses.Tb61 == model.Ans61) { i = i + 1; }
            if (responses.Tb62 == model.Ans62) { i = i + 1; }
            if (responses.Tb63 == model.Ans63) { i = i + 1; }
            if (responses.Tb64 == model.Ans64) { i = i + 1; }
            if (responses.Tb65 == model.Ans65) { i = i + 1; }
            if (responses.Tb66 == model.Ans66) { i = i + 1; }
            if (responses.Tb67 == model.Ans67) { i = i + 1; }
            if (responses.Tb68 == model.Ans68) { i = i + 1; }
            if (responses.Tb69 == model.Ans69) { i = i + 1; }
            if (responses.Tb70 == model.Ans70) { i = i + 1; }

            if (responses.Tb71 == model.Ans71) { i = i + 1; }
            if (responses.Tb72 == model.Ans72) { i = i + 1; }
            if (responses.Tb73 == model.Ans73) { i = i + 1; }
            if (responses.Tb74 == model.Ans74) { i = i + 1; }
            if (responses.Tb75 == model.Ans75) { i = i + 1; }
            if (responses.Tb76 == model.Ans76) { i = i + 1; }
            if (responses.Tb77 == model.Ans77) { i = i + 1; }
            if (responses.Tb78 == model.Ans78) { i = i + 1; }
            if (responses.Tb79 == model.Ans79) { i = i + 1; }
            if (responses.Tb80 == model.Ans80) { i = i + 1; }

            if (responses.Tb81 == model.Ans81) { i = i + 1; }
            if (responses.Tb82 == model.Ans82) { i = i + 1; }
            if (responses.Tb83 == model.Ans83) { i = i + 1; }
            if (responses.Tb84 == model.Ans84) { i = i + 1; }
            if (responses.Tb85 == model.Ans85) { i = i + 1; }
            if (responses.Tb86 == model.Ans86) { i = i + 1; }
            if (responses.Tb87 == model.Ans87) { i = i + 1; }
            if (responses.Tb88 == model.Ans88) { i = i + 1; }
            if (responses.Tb89 == model.Ans89) { i = i + 1; }
            if (responses.Tb90 == model.Ans90) { i = i + 1; }

            if (responses.Tb91 == model.Ans91) { i = i + 1; }
            if (responses.Tb92 == model.Ans92) { i = i + 1; }
            if (responses.Tb93 == model.Ans93) { i = i + 1; }
            if (responses.Tb94 == model.Ans94) { i = i + 1; }
            if (responses.Tb95 == model.Ans95) { i = i + 1; }
            if (responses.Tb96 == model.Ans96) { i = i + 1; }
            if (responses.Tb97 == model.Ans97) { i = i + 1; }
            if (responses.Tb98 == model.Ans98) { i = i + 1; }
            if (responses.Tb99 == model.Ans99) { i = i + 1; }
            if (responses.Tb100 == model.Ans100) { i = i + 1; }

            //Save score
            responses.TotalScore = i;
            return View("MathCalculations", responses);
        }
    }
}
