using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PopsConfectionary14.LogicLayer;
using PopsConfectionary14.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace PopsConfectionary14.Controllers
{
    public class RolesController : Controller
    {
        UserManager<ApplicationUser> UserManger = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
        RoleManager<IdentityRole> roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));
        ApplicationDbContext db = new ApplicationDbContext();

        RolesBusiness obj = new RolesBusiness();
        // GET: Roles
  

        public ActionResult Index()
        {
            RolesBusiness b = new RolesBusiness();
            return View(b.getall());
        }


        public ActionResult Delete(string name)
        {
            RolesViewModel model = new RolesViewModel();
            RolesBusiness n = new RolesBusiness();
            return View(n.FindByName(name));
        }

        [HttpPost]
        public ActionResult Delete(RolesViewModel model, string name)
        {
            try
            {
                model.RoleName = name;
                var result = roleManager.FindByName(model.RoleName);
                roleManager.Delete(result);


                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Message = "Error";
                return View();
            }
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(RolesViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (roleManager.RoleExists(model.RoleName))
                {
                    ViewBag.Message = "Role Already Exists";
                }
                else
                {
                    IdentityResult result = roleManager.Create(new IdentityRole(model.RoleName));
                    ViewBag.Message = "Role Created";
                }
            }
            return View(model);
        }

    }
}