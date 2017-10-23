﻿using System;
using System.Web.Mvc;
using WebApp.BLL;
using WebApp.Model;

namespace WebApp.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult LogIn()
        {
            if (Session["LoggedIn"] != null 
                && (bool)Session["LoggedIn"] == true)
            {
                return RedirectToAction("MainPage");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogIn(EmployeeLogin loggedIn)
        {
            if (new AdminBLL().EmpExists(loggedIn))
            {
                Session["LoggedIn"] = true;
                ViewBag.LoggedIn = true;
                Session["Username"] = loggedIn.Username;
                return RedirectToAction("MainPage");
            }
            else
            {
                ViewBag.LoggedIn = false;
                return View();
            }
        }

        public ActionResult MainPage()
        {
            if (Session["LoggedIn"] == null)
            {
                return RedirectToAction("LogIn");
            }
            return View(new AdminBLL().getInfo());
        }

        public ActionResult Register()
        {
            /*if (Session["LoggedIn"] == null)
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
            var bll = new AdminBLL();
            if (bll.usernameExist(inEmp.Username))
            {
                ViewBag.UsernameExist = true;
                return View();
            }
            if(bll.insertEmp(inEmp))
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
            if (Session["LoggedIn"] == null)
            {
                return RedirectToAction("LogIn");
            }
            return View();
        }

        public ActionResult ListAllEmployees()
        {
            return PartialView("_ListEmployee",new AdminBLL().listEmployee());
        }

        public ActionResult SearchEmployee(String uname)
        {
            var f = new AdminBLL().searchEmployee(uname);
            if (f == null) return null;
            return PartialView("_ListEmployee", f);
        }
        public ActionResult SearchBooking(int id)
        {
            var f = new AdminBLL().searchBooking(id);
            if (f == null) return null;
            return PartialView("ListBooking", f);
        }
        public ActionResult DetailEmployee(int id)
        {
            if (Session["LoggedIn"] == null)
            {
                return RedirectToAction("LogIn");
            }
            return View(new AdminBLL().oneEmployee(id));
        }

        public ActionResult EditEmployee(int id)
        {
            if (Session["LoggedIn"] == null)
            {
                return RedirectToAction("LogIn");
            }
            if (TempData["SelfDelete"] != null)
            {
                ViewBag.SelfDelete = (bool)TempData["SelfDelete"];
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
            return RedirectToAction("Error");
        }
        [HttpPost]
        public ActionResult DeleteEmployee(int id)
        {
            var bll = new AdminBLL();
            if(bll.getUsernameID((String)Session["Username"]) == id)
            {
                TempData["SelfDelete"] = true;
                return RedirectToAction("EditEmployee", new { id = id });
            }
            if(bll.deleteEmployee(id))
            {
                return RedirectToAction("ListEmployee");
            }
            return RedirectToAction("Error");
        }

        public ActionResult EditLogIn(int id)
        {
            if (Session["LoggedIn"] == null)
            {
                return RedirectToAction("LogIn");
            }
            var EEL = new EmployeeEditLogin();
            EEL.Username = new AdminBLL().getUsername(id);
            return View(EEL);
        }
        [HttpPost]
        public ActionResult EditLogIn(int id, EmployeeEditLogin inEEL)
        {
            var bll = new AdminBLL();
            if(bll.correctOldPassword(id, inEEL.OldPassword))
            {
                if (bll.editEmployeeLogin(id, inEEL))
                {
                    ViewBag.EditLogin = true;
                    return View();
                }
                else
                {
                    ViewBag.EditLogin = false;
                    return View();
                }
            }
            else
            {
                ViewBag.OPOK = false;
            }
            return View();
        }

        public ActionResult ListCustomer()
        {
            if (Session["LoggedIn"] == null)
            {
                return RedirectToAction("LogIn");
            }
            return View();

        }

        public ActionResult ListContactPersons()
        {
            return PartialView("_ListCustomer", new AdminBLL().listContactPersons());
        }

        public ActionResult EditCustomer(int id)
        {
            if (Session["LoggedIn"] == null)
            {
                return RedirectToAction("LogIn");
            }
            return View(new AdminBLL().oneCustomer(id));
        }

        [HttpPost]
        public ActionResult EditCustomer(int id, AdminCustomer inCust)
        {
            if (ModelState.IsValid)
            {
                if (new AdminBLL().editCustomer(id, inCust))
                {
                    return RedirectToAction("ListCustomer");
                }
            }
            return RedirectToAction("Error");
        }

        public ActionResult DeleteCustomer(int id)
        {
            if (new AdminBLL().deleteCustomer(id))
            {
                return RedirectToAction("ListCustomer");
            }
            return RedirectToAction("Error");
        }


        public ActionResult CustomerBooking(int id)
        {
            return View(new AdminBLL().customerBooking(id));
        }

        public ActionResult DetailCustomer(int id)
        {
            if (Session["LoggedIn"] == null)
            {
                return RedirectToAction("LogIn");
            }
            return View(new AdminBLL().detailCustomer(id));
        }

        public ActionResult ListBooking()
        {
            if (Session["LoggedIn"] == null)
            {
                return RedirectToAction("LogIn");
            }
            return View(new AdminBLL().listBookings());
        }

        public ActionResult ListFlight()
        {
            if (Session["LoggedIn"] == null)
            {
                return RedirectToAction("LogIn");
            }
            if (TempData["FlightInsert"] != null)
            {
                ViewBag.FlightInsert = (bool)TempData["FlightInsert"];
            }
            if(TempData["FlightEdit"] != null)
            {
                ViewBag.FlightEdit = (bool)TempData["FlightEdit"];
            }
            return View();
        }
        
        public ActionResult ListAllFlights()
        {
            return PartialView("_ListFlight", new AdminBLL().listAllFlights());
        }
        public ActionResult SearchFlights(SearchFlight search)
        {
            return PartialView("_ListFlight", new AdminBLL().searchFlight(search));
            
        }

        public ActionResult SearchCustomers(int id)
        {
            var f = new AdminBLL().searchCustomer(id);
            if (f == null) return null;
            return PartialView("_ListCustomer", f);
        }

        

        public ActionResult NewFlight()
        {
            if (Session["LoggedIn"] == null)
            {
                return RedirectToAction("LogIn");
            }
            var f = new AdminFlight();
            var bll = new AdminBLL();
            f.Airports = bll.listAirports();
            f.Airplanes = bll.listAirplanes();
            f.Airports.Insert(0,null);
            f.Airplanes.Insert(0,null);
            return View(f);
        }

        [HttpPost]
        public ActionResult NewFlight(AdminFlight inFlight)
        {
            if (ModelState.IsValid)
            {
                if(new AdminBLL().insertFlight(inFlight))
                {
                    TempData["FlightInsert"] = true;
                    return RedirectToAction("ListFlight");
                }
            }
            return RedirectToAction("Error");
        }

        public ActionResult EditFlight(int id)
        {
            if (Session["LoggedIn"] == null)
            {
                return RedirectToAction("LogIn");
            }
            var bll = new AdminBLL();
            var f = bll.oneFlight(id);
            f.Airplanes = bll.listAirplanes();
            f.Airports = bll.listAirports();
            return View(f);
        }
        [HttpPost]
        public ActionResult EditFlight(int id, AdminFlight inFlight)
        {
            if (ModelState.IsValid)
            {
                if (new AdminBLL().editFlight(id, inFlight)) {
                    TempData["FlightEdit"] = true;
                    return RedirectToAction("ListFlight");
                }
            }
            return RedirectToAction("Error");
        }
        [HttpPost]
        public ActionResult DeleteFlight(int id)
        {
            if (new AdminBLL().deleteFlight(id))
            {
                return RedirectToAction("ListFlight");
            }
            return RedirectToAction("Error");
        }

        public ActionResult Passengers(int id)
        {
            if (Session["LoggedIn"] == null)
            {
                return RedirectToAction("LogIn");
            }
            return View(new AdminBLL().getPassengers(id));
        }

        public ActionResult ListAirplane()
        {
            if (Session["LoggedIn"] == null)
            {
                return RedirectToAction("LogIn");
            }
            return View(new AdminBLL().listAirplanes());
        }

        public ActionResult NewAirplane()
        {
            if (Session["LoggedIn"] == null)
            {
                return RedirectToAction("LogIn");
            }
            return View();
        }
        [HttpPost]
        public ActionResult NewAirplane(AdminAirplane inAir)
        {
            if (ModelState.IsValid)
            {
                if(new AdminBLL().insertAirplane(inAir))
                {
                    return RedirectToAction("ListAirPlane");
                }
            }
            return RedirectToAction("Error");
        }

        public ActionResult EditAirplane(int id)
        {
            if (Session["LoggedIn"] == null)
            {
                return RedirectToAction("LogIn");
            }
            return View(new AdminBLL().oneAirplane(id));
        }
        [HttpPost]
        public ActionResult EditAirplane(int id, AdminAirplane inAir)
        {
            if (ModelState.IsValid)
            {
                if (new AdminBLL().editAirplane(id, inAir))
                {
                    return RedirectToAction("ListAirplane");
                }
            }
            return RedirectToAction("Error");
        }

        [HttpPost]
        public ActionResult DeleteAirplane(int id)
        {
            if(new AdminBLL().deleteAirplane(id))
            {
                return RedirectToAction("ListAirplane");
            }
            return RedirectToAction("Error");
        }

        public ActionResult ListAirport()
        {
            if (Session["LoggedIn"] == null)
            {
                return RedirectToAction("LogIn");
            }
            return View(new AdminBLL().listAirports());
        }

        public ActionResult NewAirport()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewAirport(AdminAirport inAir)
        {
            if (ModelState.IsValid)
            {
                if (new AdminBLL().insertAirport(inAir))
                {
                    return RedirectToAction("ListAirPort");
                }
            }
            return RedirectToAction("Error");
        }

        public ActionResult EditAirport(int id)
        {
            if (Session["LoggedIn"] == null)
            {
                return RedirectToAction("LogIn");
            }
            return View(new AdminBLL().oneAirport(id));
        }
        [HttpPost]
        public ActionResult EditAirport(int id, AdminAirport inAir)
        {
            if (ModelState.IsValid)
            {
                if (new AdminBLL().editAirPort(id,inAir))
                {
                    return RedirectToAction("ListAirport");
                }
            }
            return RedirectToAction("Error");
        }

        [HttpPost]
        public ActionResult DeleteAirport(int id)
        {
            if (new AdminBLL().deleteAirport(id))
            {
                return RedirectToAction("ListAirport");
            }
            return RedirectToAction("Error");
        }

        public ActionResult LogOut()
        {
            Session["LoggedIn"] = null;
            Session["Username"] = null;
            return RedirectToAction("LogIn");
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}