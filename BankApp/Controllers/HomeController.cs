using BankApp.Models.DB_Model;
using BankApp.Models.View_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(NewCustomers newcustomer)
        {
            try
            {
                var db = new BankDb();
                var cust = new Customerprofile();
                cust.FirstName = newcustomer.FirstName;
                cust.LastName = newcustomer.LastName;
                cust.DOB = newcustomer.DOB;
                cust.RegistrationDate = DateTime.UtcNow.AddHours(1);
                db.Customerprofiles.Add(cust);
                db.SaveChanges();
                return RedirectToAction("SuccessfulReg");
            }
            catch (Exception)
            {

                ViewBag.ErrorMessage = "An Error Occurred during Registration";
                return View();
            }
            
        }

        public ActionResult SuccessfulReg()
        {
            return View();
        }
    }
}