using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
//    public class ProfileController : Controller
//    {
//        private ApplicationDbContext db = new ApplicationDbContext();
//        // GET: Profile

   
//        public ActionResult Index()
//        {
//            List<RoleViewModels> list = new List<RoleViewModels>();
//            foreach (var role in RoleManager.Roles)
//                list.Add(new RoleViewModels(role));
//            return View(list);
           
//        }

//        public ActionResult Profile(int id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            CustomerModel customerModel = db.CustomerModels.Find(id);
//            if (customerModel == null)
//            {
//                return HttpNotFound();
//            }
//            return View(customerModel);
//        }
//    }
}