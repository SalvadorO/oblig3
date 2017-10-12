﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppAdmin.BLL;
using WebAppAdmin.Model;

namespace WebAppAdmin.Controllers
{
    public class HomeController : Controller
    {
        // Kode brukt fra forelesning
        public ActionResult LogIn()
        {
            if (Session["LoggedIn"] == null)
            {
                Session["LoggedIn"] = false;
                ViewBag.LoggedIn = false;
            }
            else
            {
                ViewBag.LoggedIn = (bool)Session["LoggedIn"];
            }
            return View();
        }

        // Kode brukt fra forelesning
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogIn(EmployeeLogin loggedIn)
        {
            if (new AdminBLL().EmpExists(loggedIn))
            {
                Session["LoggedIn"] = true;
                ViewBag.LoggedIn = true;
                return View();
            }
            else
            {
                Session["LoggedIn"] = false;
                ViewBag.LoggedIn = false;
                return View();
            }
        }

        public ActionResult Register()
        {
            /*if ((bool)Session["LoggedIn"] == false)
            {
                return RedirectToAction("LogIn");
            }*/
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(EmployeeRegister inEmp)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Error");
            }
            if(new AdminBLL().insertEmp(inEmp))
            {
                return View();
            }
            else
            {
                return RedirectToAction("Error");
            }
        }

        public ActionResult ListEmployee()
        {
            if ((bool)Session["LoggedIn"] == false)
            {
                return RedirectToAction("LogIn");
            }
            return View(new AdminBLL().listEmployee());
        }

        public ActionResult DetailEmployee(int id)
        {
            if ((bool)Session["LoggedIn"] == false)
            {
                return RedirectToAction("LogIn");
            }
            return View(new AdminBLL().oneEmployee(id));
        }

        public ActionResult EditEmployee(int id)
        {
            if ((bool)Session["LoggedIn"] == false)
            {
                return RedirectToAction("LogIn");
            }
            return View(new AdminBLL().oneEmployee(id));
        }

        [HttpPost]
        public ActionResult EditEmployee(int id,Employee inEmp)
        {
            if (ModelState.IsValid)
            {
                if (new AdminBLL().editEmployee(id, inEmp))
                {
                    return RedirectToAction("ListEmployee");
                }
            }
            return View();
        }
        [HttpPost]
        public ActionResult DeleteEmployee(int id)
        {
            if(new AdminBLL().deleteEmployee(id))
            {
                return RedirectToAction("ListEmployee");
            }
            return RedirectToAction("Error");
        }

        public ActionResult LogOut()
        {
            Session["LoggedIn"] = false;
            return RedirectToAction("LogIn");
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}