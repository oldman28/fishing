using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FisherShop.Models;

namespace FisherShop.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            DataBaseDataContext db = new DataBaseDataContext();
            List <Items> itemList = db.Items.ToList();
            return View(itemList);
        }
    }
}