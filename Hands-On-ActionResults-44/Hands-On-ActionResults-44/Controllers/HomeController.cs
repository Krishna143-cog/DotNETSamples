using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hands_On_ActionResults_44.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.ItemList = "Rainy Morning";
            return View();
        }
        //public EmptyResult Index()
        //{
        //    ViewBag.ItemList = "Book Ganga Item List Page";
        //    return new EmptyResult();
        //}
        //public RedirectResult Index()
        //{
        //    return Redirect("Home/Contact");
        //}
        [HttpGet]
        public FileResult Download()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(@"E:\data.txt");
            string filename = "data.txt";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, filename);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        //public JsonResult Index()
        //{
        //    Employee emp = new Employee()
        //    {
        //        ID = "Emp23",
        //        Name = "Steven Clark",
        //        Mobile = "825415426"
        //    };
        //    return Json(emp, JsonRequestBehavior.AllowGet);
        //}
        //public class Employee
        //{
        //    public string ID { get; set; }
        //    public string Name { get; set; }
        //    public string Mobile { get; set; }
        //}
        //public ContentResult Index()
        //{
        //    return Content("Hello ASP.NET MVC 5", "text/plain", System.Text.Encoding.UTF8);
        //}
        [HttpGet]
        public JavaScriptResult WarningMessage()
        {
            var msg = "alert('Are you sure want to Continue?');";
            return new JavaScriptResult() { Script = msg };
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public PartialViewResult messagepage()
        {
            return PartialView("message");
        }
    }
}