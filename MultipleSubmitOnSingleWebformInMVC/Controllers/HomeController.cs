using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MultipleSubmitOnSingleWebformInMVC.Models;

namespace MultipleSubmitOnSingleWebformInMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Employee emp,string create,string edit)
        {
            /*3 ways to use multiple submit */

            ///////////////////////

            if (create == "create")
            {
                //Create code
            }
            if (edit == "edit")
            {
                //edit code
            }
            ///////////////////////
            /*
             if we use submit button as parameter
            if (submit == "create")
            {
                //Create code
            }
            if (submit == "edit")
            {
                //edit code
            }
            */

            ///////////////////////
            

            return View();
        }
        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            return RedirectToAction("Index");
        }

    }
}