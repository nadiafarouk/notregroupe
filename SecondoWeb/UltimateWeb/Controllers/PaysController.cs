using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace UltimateWeb.Controllers
{
    public class PaysController : Controller
    {
        // GET: Pays


        private LesPaysBdEntities ctx = new LesPaysBdEntities();


        public ActionResult List()
        {

            var pays = ctx.Pays.ToList();

            return View(pays);
        }
    }
}