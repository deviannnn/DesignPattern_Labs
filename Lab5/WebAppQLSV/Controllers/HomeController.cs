using DatabaseLib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using WebAppQLSV.Models;

namespace WebAppQLSV.Controllers
{
    public class HomeController : Controller
    {
        public StudentDAO GetStudentDAO()
        {
            var dbType = WebConfigurationManager.AppSettings["DBType"];
            var cnString = WebConfigurationManager.ConnectionStrings["DbConnectionStr"].ConnectionString;
            DatabaseFactory databaseFactory = new SimpleDatabaseFactory().CreateDbFactory(dbType, cnString);
            return new StudentDAO(databaseFactory);
        }

        public ActionResult Index()
        {
            return View(GetStudentDAO().GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "Code,Name,Birthday,Class")] Student student)
        {
            var studentDAO = GetStudentDAO();
            if (studentDAO.IsCodeExists(student.Code))
            {
                ModelState.AddModelError("Code", student.Code + " already exists");
                return View(student);
            }

            if (ModelState.IsValid)
            {
                if (studentDAO.Create(student))
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Adding new students failed.");
                }
            }

            return View(student);
        }

        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var student = GetStudentDAO().GetByCode(id);
            if (student == null)
            {
                return HttpNotFound();
            }

            return View(student);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "Code,Name,Birthday,Class")] Student student)
        {
            if (ModelState.IsValid)
            {
                var studentDAO = GetStudentDAO();
                if (studentDAO.Update(student))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Failed to update student!");
                }
            }
            return View(student);
        }

        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var student = GetStudentDAO().GetByCode(id);
            if (student == null)
            {
                return HttpNotFound();
            }

            return View(student);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {
            if(GetStudentDAO().Delete(id))
            {
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Failed to delete student!");
                return View(GetStudentDAO().GetByCode(id));
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}