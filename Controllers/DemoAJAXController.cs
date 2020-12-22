using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL;

namespace MVCAJAX.Controllers
{
    public class DemoAJAXController : Controller
    {
        // GET: DemoAJAX
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Edit(Student s)
        {
            return Json(StudentManager.Edit(s), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetRows()
        {
            return Json(StudentManager.GetRows(), JsonRequestBehavior.AllowGet);

        }

        public ActionResult GetById(int id)
        {
            return Json(StudentManager.GetById(id), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Update()
        {
            return View();
        }
        public ActionResult PageListDemo(int pageIndex,int pageSize)
        {
           //return Json(StudentManager.GetStudent(pageIndex,pageSize),JsonRequestBehavior.AllowGet);
            return Json(StudentManager.PageListDemo(pageIndex,pageSize),JsonRequestBehavior.AllowGet); 
        }


        public ActionResult Del(int id)
        {
            //return Json(StudentManager.GetStudent(pageIndex,pageSize),JsonRequestBehavior.AllowGet);
            return Json(StudentManager.Del(id), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Add(Student s)
        {
            //return Json(StudentManager.GetStudent(pageIndex,pageSize),JsonRequestBehavior.AllowGet);
            return Json(StudentManager.Add(s), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetDepts()
        {
           
            return Json(DeptManager.GetDepts(), JsonRequestBehavior.AllowGet);
        }
    }
}