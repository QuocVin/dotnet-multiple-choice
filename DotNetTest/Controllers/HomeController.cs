using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using DotNetTest.Models;

namespace DotNetTest.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private MULTIPLE_CHOICE_Entities db = new MULTIPLE_CHOICE_Entities();

        public ActionResult Index()
        {
            return View(db.subjects.ToList());

        }

        // GET: Home/DoExam/5
        public ActionResult DoExam(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            exam exam = db.exams.Find(id);
            ViewBag.questions3 = exam.questions.ToArray();
            System.Diagnostics.Debug.Write("\n-------------------------------------------------------------------------------------------------------\n");
          
            System.Diagnostics.Debug.Write("\n-------------------------------------------------------------------------------------------------------\n");
            if (exam == null)
            {
                return HttpNotFound();
            }
            return View(exam);
        }
    }
}