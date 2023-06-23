using System;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyWithValidationsNew.Models;

namespace DojoSurveyWithValidationsNew.Controllers
{
	public class DojoSurveyController : Controller
	{
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost("process")]
        public IActionResult Process(SurveyModel surveyModel)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Results", surveyModel);
            }

            return View("Index");
        }

        [HttpGet("results")]
        public IActionResult Results(SurveyModel surveyModel)
        {
            return View("Results", surveyModel);
        }
    }
}

