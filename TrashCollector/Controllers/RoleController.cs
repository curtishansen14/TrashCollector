﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.Owin;
using TrashCollector.Models;
using System.Threading.Tasks;

namespace TrashCollector.Controllers
{
    public class RoleController : Controller
    {

        private ApplicationRoleManager _roleManager;

        public RoleController()
        {
        }

        public RoleController(ApplicationRoleManager roleManager)
        {
            RoleManager = roleManager; 
        }

        public ApplicationRoleManager RoleManager
        {
            get
            {
                return _roleManager ?? HttpContext.GetOwinContext().Get<ApplicationRoleManager>();
            }
            private set
            {
                _roleManager = value;
            }
        }

        // GET: Role
        public ActionResult Index()
        {

            List<RoleViewModels> list = new List<RoleViewModels>();
            foreach (var role in RoleManager.Roles)
                list.Add(new RoleViewModels(role));
            return View(list);
        }

        //public ActionResult Role()
        //{

        //    List<RoleViewModels> list = new List<RoleViewModels>();
        //    foreach (var role in RoleManager.Roles)
        //        list.Add(new RoleViewModels(role));
        //    return View(list);
        //}

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(RoleViewModels model)
        {
            var role = new ApplicationRole() { Name = model.Name };
            await RoleManager.CreateAsync(role);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Edit(string id)
        {
            var role = await RoleManager.FindByIdAsync(id);
            return View(new RoleViewModels(role));
        }

        [HttpPost]

        public async Task<ActionResult> Edit(RoleViewModels model)
        {
            var role = new ApplicationRole() { Id = model.Id, Name = model.Name };
            await RoleManager.UpdateAsync(role);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Detail(string id)
        {
            var role = await RoleManager.FindByIdAsync(id);
            return View(new RoleViewModels(role));
        }

        public async Task<ActionResult> Delete(string id)
        {
            var role = await RoleManager.FindByIdAsync(id);
            return View(new RoleViewModels(role));
        }

        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            var role = await RoleManager.FindByIdAsync(id);
            await RoleManager.DeleteAsync(role);
            return RedirectToAction("Index");
        }

    }
}