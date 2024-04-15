using NewsWebApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsWebApp.Controllers
{
    public class SimpleSourceFactory
    {
        public INewsDAO CreateSourceDAO(int type, string conStr = null)
        {
            if (type == 1)
                return new ThanhNienAdapter();
            else if (type == 2)
                return new VNExpressAdapter();
            else
                return new NewsDAO(conStr);
        }
    }

    public class HomeController : Controller
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["DbConnectionStr"].ConnectionString;

        public ActionResult Index(int id = 0)
        {
            int type = 0;
            if (Session["Source"] != null)
            {
                type = (int)Session["Source"];
            }

            INewsDAO newsDAO = new SimpleSourceFactory().CreateSourceDAO(type, ConnectionString);

            ViewBag.Title = "Trang Chủ";
            var cate = newsDAO.GetCategory(id);
            if (cate == null)
                id = 0;
            else
                ViewBag.Title = cate.Name;
            ViewBag.AllCategory = newsDAO.GetAllCategories();  
            return View(newsDAO.GetNewsByCategory(id));
        }

        public ActionResult Details(int id)
        {
            int type = 0;
            if (Session["Source"] != null)
            {
                type = (int)Session["Source"];
            }

            INewsDAO newsDAO = new SimpleSourceFactory().CreateSourceDAO(type, ConnectionString);
            var news = newsDAO.GetNews(id);
            ViewBag.AllCategory = newsDAO.GetAllCategories();
            if (news == null)
            {
                return View("Error");
            }

            return View(news);
        }

        public ActionResult ChangeSource(int id)
        {
            Session["Source"] = id;  
            return RedirectToAction("Index");
        }
    }
}