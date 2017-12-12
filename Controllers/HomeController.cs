using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxPractice.Models;
using AjaxPractice.DAL;

namespace AjaxPractice.Controllers
{
    public class HomeController : Controller
    {
        private AjaxPracticeContext db = new AjaxPracticeContext();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            List<Staff> staffList = db.Staffs.ToList();
            List<SelectListItem> dropdownList = new List<SelectListItem>();
            foreach (Staff s in staffList)
            {
                dropdownList.Add(new SelectListItem() { Text = s.Name, Value = s.StaffID.ToString() });
            }

            ViewBag.dropdownList = dropdownList;
            return View();
        }

        [HttpPost]
        public ActionResult GetSupervisorForEmployeeByID(int id)
        {
            Staff s = db.Staffs.Find(id);
            Group g = db.Groups.Find(s.GroupID);
            Staff supervisor = db.Staffs.Find(g.SupervisorID);

            return Json(supervisor, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult GetSupervisorForEmployeeByName(String name)
        {
            Staff s = db.Staffs.Where(x => x.Name == name).FirstOrDefault();
            Staff supervisor = null;
            if (s != null)
            {
                Group g = db.Groups.Find(s.GroupID);
                supervisor = db.Staffs.Find(g.SupervisorID);
            }

            return Json(supervisor, JsonRequestBehavior.AllowGet);
        }
    }
}
