﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        // View med søk
        public ActionResult ChooseFlight()
        {
            
            var db =  new WebAppContext();
            db.Database.Delete();

           var Airport1 = new Airport { Name = "Oslo", Country = "Norge" };
           var Airport2 = new Airport { Name = "Værnes", Country = "Norge" };
           var Airport3 = new Airport { Name = "Tromsø", Country = "Norge" };
           var Airport4 = new Airport { Name = "Bardufoss", Country = "Norge" };
           var Airport5 = new Airport { Name = "Torp", Country = "Norge" };
           var Airport6 = new Airport { Name = "Sola", Country = "Norge" };
           var Airport7 = new Airport { Name = "Flesland", Country = "Norge" };
           var Airport8 = new Airport { Name = "Hammerfest", Country = "Norge" };

           db.Airport.Add(Airport1);
           db.Airport.Add(Airport2);
           db.Airport.Add(Airport3);
           db.Airport.Add(Airport4);
           db.Airport.Add(Airport5);
           db.Airport.Add(Airport6);
           db.Airport.Add(Airport7);
           db.Airport.Add(Airport8);

            var Flight1 = new Flight { Departure = 1, DepartureTime = "09:00", Destination = 2, DestinationTime = "11:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight2 = new Flight { Departure = 1, DepartureTime = "12:00", Destination = 2, DestinationTime = "14:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight3 = new Flight { Departure = 1, DepartureTime = "15:00", Destination = 2, DestinationTime = "17:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight4 = new Flight { Departure = 1, DepartureTime = "18:00", Destination = 2, DestinationTime = "20:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight5 = new Flight { Departure = 1, DepartureTime = "21:00", Destination = 2, DestinationTime = "23:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight6 = new Flight { Departure = 1, DepartureTime = "09:00", Destination = 2, DestinationTime = "11:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight7 = new Flight { Departure = 1, DepartureTime = "12:00", Destination = 2, DestinationTime = "14:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight8 = new Flight { Departure = 1, DepartureTime = "15:00", Destination = 2, DestinationTime = "17:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight9 = new Flight { Departure = 1, DepartureTime = "18:00", Destination = 2, DestinationTime = "20:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight10 = new Flight { Departure = 1, DepartureTime = "21:00", Destination = 2, DestinationTime = "23:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };

            var Flight11 = new Flight { Departure = 1, DepartureTime = "09:00", Destination = 3, DestinationTime = "11:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1200 };
            var Flight12 = new Flight { Departure = 1, DepartureTime = "12:00", Destination = 3, DestinationTime = "14:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1200 };
            var Flight13 = new Flight { Departure = 1, DepartureTime = "15:00", Destination = 3, DestinationTime = "18:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1200 };
            var Flight14 = new Flight { Departure = 1, DepartureTime = "18:00", Destination = 3, DestinationTime = "20:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1200 };
            var Flight15 = new Flight { Departure = 1, DepartureTime = "21:00", Destination = 3, DestinationTime = "23:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1200 };
            var Flight16 = new Flight { Departure = 1, DepartureTime = "09:00", Destination = 3, DestinationTime = "11:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2500 };
            var Flight17 = new Flight { Departure = 1, DepartureTime = "12:00", Destination = 3, DestinationTime = "14:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2500 };
            var Flight18 = new Flight { Departure = 1, DepartureTime = "15:00", Destination = 3, DestinationTime = "17:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2500 };
            var Flight19 = new Flight { Departure = 1, DepartureTime = "18:00", Destination = 3, DestinationTime = "20:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2500 };
            var Flight20 = new Flight { Departure = 1, DepartureTime = "21:00", Destination = 3, DestinationTime = "23:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2500 };

            var Flight21 = new Flight { Departure = 1, DepartureTime = "10:00", Destination = 6, DestinationTime = "11:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight22 = new Flight { Departure = 1, DepartureTime = "13:00", Destination = 6, DestinationTime = "14:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight23 = new Flight { Departure = 1, DepartureTime = "16:00", Destination = 6, DestinationTime = "17:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight24 = new Flight { Departure = 1, DepartureTime = "19:00", Destination = 6, DestinationTime = "20:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight25 = new Flight { Departure = 1, DepartureTime = "22:00", Destination = 6, DestinationTime = "23:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight26 = new Flight { Departure = 1, DepartureTime = "10:00", Destination = 6, DestinationTime = "11:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };
            var Flight27 = new Flight { Departure = 1, DepartureTime = "13:00", Destination = 6, DestinationTime = "14:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };
            var Flight28 = new Flight { Departure = 1, DepartureTime = "16:00", Destination = 6, DestinationTime = "17:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };
            var Flight29 = new Flight { Departure = 1, DepartureTime = "19:00", Destination = 6, DestinationTime = "20:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };
            var Flight30 = new Flight { Departure = 1, DepartureTime = "22:00", Destination = 6, DestinationTime = "23:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };

            var Flight31 = new Flight { Departure = 1, DepartureTime = "10:00", Destination = 7, DestinationTime = "11:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight32 = new Flight { Departure = 1, DepartureTime = "13:00", Destination = 7, DestinationTime = "14:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight33 = new Flight { Departure = 1, DepartureTime = "16:00", Destination = 7, DestinationTime = "17:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight34 = new Flight { Departure = 1, DepartureTime = "19:00", Destination = 7, DestinationTime = "20:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight35 = new Flight { Departure = 1, DepartureTime = "22:00", Destination = 7, DestinationTime = "23:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight36 = new Flight { Departure = 1, DepartureTime = "10:00", Destination = 7, DestinationTime = "11:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };
            var Flight37 = new Flight { Departure = 1, DepartureTime = "13:00", Destination = 7, DestinationTime = "14:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };
            var Flight38 = new Flight { Departure = 1, DepartureTime = "16:00", Destination = 7, DestinationTime = "17:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };
            var Flight39 = new Flight { Departure = 1, DepartureTime = "19:00", Destination = 7, DestinationTime = "20:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };
            var Flight40 = new Flight { Departure = 1, DepartureTime = "22:00", Destination = 7, DestinationTime = "23:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };

            var Flight41 = new Flight { Departure = 2, DepartureTime = "09:00", Destination = 1, DestinationTime = "11:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight42 = new Flight { Departure = 2, DepartureTime = "12:00", Destination = 1, DestinationTime = "14:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight43 = new Flight { Departure = 2, DepartureTime = "15:00", Destination = 1, DestinationTime = "17:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight44 = new Flight { Departure = 2, DepartureTime = "18:00", Destination = 1, DestinationTime = "20:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight45 = new Flight { Departure = 2, DepartureTime = "21:00", Destination = 1, DestinationTime = "23:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight46 = new Flight { Departure = 2, DepartureTime = "09:00", Destination = 1, DestinationTime = "11:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight47 = new Flight { Departure = 2, DepartureTime = "12:00", Destination = 1, DestinationTime = "14:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight48 = new Flight { Departure = 2, DepartureTime = "15:00", Destination = 1, DestinationTime = "17:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight49 = new Flight { Departure = 2, DepartureTime = "18:00", Destination = 1, DestinationTime = "20:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight50 = new Flight { Departure = 2, DepartureTime = "21:00", Destination = 1, DestinationTime = "23:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };

            var Flight51 = new Flight { Departure = 2, DepartureTime = "09:00", Destination = 3, DestinationTime = "10:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1000 };
            var Flight52 = new Flight { Departure = 2, DepartureTime = "12:00", Destination = 3, DestinationTime = "13:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1000 };
            var Flight53 = new Flight { Departure = 2, DepartureTime = "15:00", Destination = 3, DestinationTime = "16:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1000 };
            var Flight54 = new Flight { Departure = 2, DepartureTime = "18:00", Destination = 3, DestinationTime = "17:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1000 };
            var Flight55 = new Flight { Departure = 2, DepartureTime = "21:00", Destination = 3, DestinationTime = "22:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1000 };
            var Flight56 = new Flight { Departure = 2, DepartureTime = "09:00", Destination = 3, DestinationTime = "10:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2200 };
            var Flight57 = new Flight { Departure = 2, DepartureTime = "12:00", Destination = 3, DestinationTime = "13:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2200 };
            var Flight58 = new Flight { Departure = 2, DepartureTime = "15:00", Destination = 3, DestinationTime = "16:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2200 };
            var Flight59 = new Flight { Departure = 2, DepartureTime = "18:00", Destination = 3, DestinationTime = "19:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2200 };
            var Flight60 = new Flight { Departure = 2, DepartureTime = "21:00", Destination = 3, DestinationTime = "22:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2200 };

            var Flight61 = new Flight { Departure = 2, DepartureTime = "09:00", Destination = 5, DestinationTime = "11:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight62 = new Flight { Departure = 2, DepartureTime = "12:00", Destination = 5, DestinationTime = "14:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight63 = new Flight { Departure = 2, DepartureTime = "15:00", Destination = 5, DestinationTime = "17:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight64 = new Flight { Departure = 2, DepartureTime = "18:00", Destination = 5, DestinationTime = "20:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight65 = new Flight { Departure = 2, DepartureTime = "21:00", Destination = 5, DestinationTime = "23:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight66 = new Flight { Departure = 2, DepartureTime = "09:00", Destination = 5, DestinationTime = "11:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight67 = new Flight { Departure = 2, DepartureTime = "12:00", Destination = 5, DestinationTime = "14:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight68 = new Flight { Departure = 2, DepartureTime = "15:00", Destination = 5, DestinationTime = "17:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight69 = new Flight { Departure = 2, DepartureTime = "18:00", Destination = 5, DestinationTime = "20:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight70 = new Flight { Departure = 2, DepartureTime = "21:00", Destination = 5, DestinationTime = "23:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };

            var Flight71 = new Flight { Departure = 2, DepartureTime = "09:00", Destination = 7, DestinationTime = "11:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight72 = new Flight { Departure = 2, DepartureTime = "12:00", Destination = 7, DestinationTime = "14:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight73 = new Flight { Departure = 2, DepartureTime = "15:00", Destination = 7, DestinationTime = "17:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight74 = new Flight { Departure = 2, DepartureTime = "18:00", Destination = 7, DestinationTime = "20:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight75 = new Flight { Departure = 2, DepartureTime = "21:00", Destination = 7, DestinationTime = "23:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight76 = new Flight { Departure = 2, DepartureTime = "09:00", Destination = 7, DestinationTime = "11:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight77 = new Flight { Departure = 2, DepartureTime = "12:00", Destination = 7, DestinationTime = "14:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight78 = new Flight { Departure = 2, DepartureTime = "15:00", Destination = 7, DestinationTime = "17:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight79 = new Flight { Departure = 2, DepartureTime = "18:00", Destination = 7, DestinationTime = "20:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight80 = new Flight { Departure = 2, DepartureTime = "21:00", Destination = 7, DestinationTime = "23:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };

            var Flight81 = new Flight { Departure = 3, DepartureTime = "09:00", Destination = 1, DestinationTime = "11:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1200 };
            var Flight82 = new Flight { Departure = 3, DepartureTime = "12:00", Destination = 1, DestinationTime = "14:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1200 };
            var Flight83 = new Flight { Departure = 3, DepartureTime = "15:00", Destination = 1, DestinationTime = "18:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1200 };
            var Flight84 = new Flight { Departure = 3, DepartureTime = "18:00", Destination = 1, DestinationTime = "20:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1200 };
            var Flight85 = new Flight { Departure = 3, DepartureTime = "21:00", Destination = 1, DestinationTime = "23:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1200 };
            var Flight86 = new Flight { Departure = 3, DepartureTime = "09:00", Destination = 1, DestinationTime = "11:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2500 };
            var Flight87 = new Flight { Departure = 3, DepartureTime = "12:00", Destination = 1, DestinationTime = "14:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2500 };
            var Flight88 = new Flight { Departure = 3, DepartureTime = "15:00", Destination = 1, DestinationTime = "17:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2500 };
            var Flight89 = new Flight { Departure = 3, DepartureTime = "18:00", Destination = 1, DestinationTime = "20:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2500 };
            var Flight90 = new Flight { Departure = 3, DepartureTime = "21:00", Destination = 1, DestinationTime = "23:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2500 };

            var Flight91 = new Flight { Departure = 3, DepartureTime = "09:00", Destination = 2, DestinationTime = "10:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1000 };
            var Flight92 = new Flight { Departure = 3, DepartureTime = "12:00", Destination = 2, DestinationTime = "13:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1000 };
            var Flight93 = new Flight { Departure = 3, DepartureTime = "15:00", Destination = 2, DestinationTime = "16:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1000 };
            var Flight94 = new Flight { Departure = 3, DepartureTime = "18:00", Destination = 2, DestinationTime = "17:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1000 };
            var Flight95 = new Flight { Departure = 3, DepartureTime = "21:00", Destination = 2, DestinationTime = "22:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1000 };
            var Flight96 = new Flight { Departure = 3, DepartureTime = "09:00", Destination = 2, DestinationTime = "10:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2200 };
            var Flight97 = new Flight { Departure = 3, DepartureTime = "12:00", Destination = 2, DestinationTime = "13:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2200 };
            var Flight98 = new Flight { Departure = 3, DepartureTime = "15:00", Destination = 2, DestinationTime = "16:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2200 };
            var Flight99 = new Flight { Departure = 3, DepartureTime = "18:00", Destination = 2, DestinationTime = "19:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2200 };
            var Flight100 = new Flight { Departure = 3, DepartureTime = "21:00", Destination = 3, DestinationTime = "22:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2200 };

            var Flight101 = new Flight { Departure = 3, DepartureTime = "08:00", Destination = 4, DestinationTime = "09:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight102 = new Flight { Departure = 3, DepartureTime = "11:00", Destination = 4, DestinationTime = "12:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight103 = new Flight { Departure = 3, DepartureTime = "14:00", Destination = 4, DestinationTime = "15:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight104 = new Flight { Departure = 3, DepartureTime = "17:00", Destination = 4, DestinationTime = "18:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight105 = new Flight { Departure = 3, DepartureTime = "20:00", Destination = 4, DestinationTime = "21:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight106 = new Flight { Departure = 3, DepartureTime = "08:00", Destination = 4, DestinationTime = "09:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight107 = new Flight { Departure = 3, DepartureTime = "11:00", Destination = 4, DestinationTime = "12:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight108 = new Flight { Departure = 3, DepartureTime = "14:00", Destination = 4, DestinationTime = "15:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight109 = new Flight { Departure = 3, DepartureTime = "17:00", Destination = 4, DestinationTime = "18:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight110 = new Flight { Departure = 3, DepartureTime = "20:00", Destination = 4, DestinationTime = "21:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };

            var Flight111 = new Flight { Departure = 3, DepartureTime = "08:00", Destination = 5, DestinationTime = "11:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight112 = new Flight { Departure = 3, DepartureTime = "11:00", Destination = 5, DestinationTime = "14:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight113 = new Flight { Departure = 3, DepartureTime = "14:00", Destination = 5, DestinationTime = "17:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight114 = new Flight { Departure = 3, DepartureTime = "17:00", Destination = 5, DestinationTime = "20:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight115 = new Flight { Departure = 3, DepartureTime = "20:00", Destination = 5, DestinationTime = "23:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight116 = new Flight { Departure = 3, DepartureTime = "08:00", Destination = 5, DestinationTime = "11:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight117 = new Flight { Departure = 3, DepartureTime = "11:00", Destination = 5, DestinationTime = "14:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight118 = new Flight { Departure = 3, DepartureTime = "14:00", Destination = 5, DestinationTime = "17:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight119 = new Flight { Departure = 3, DepartureTime = "17:00", Destination = 5, DestinationTime = "20:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight120 = new Flight { Departure = 3, DepartureTime = "20:00", Destination = 5, DestinationTime = "23:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };

            var Flight121 = new Flight { Departure = 3, DepartureTime = "09:00", Destination = 6, DestinationTime = "11:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight122 = new Flight { Departure = 3, DepartureTime = "12:00", Destination = 6, DestinationTime = "14:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight123 = new Flight { Departure = 3, DepartureTime = "15:00", Destination = 6, DestinationTime = "17:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight124 = new Flight { Departure = 3, DepartureTime = "18:00", Destination = 6, DestinationTime = "20:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight125 = new Flight { Departure = 3, DepartureTime = "21:00", Destination = 6, DestinationTime = "23:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight126 = new Flight { Departure = 3, DepartureTime = "09:00", Destination = 6, DestinationTime = "11:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight127 = new Flight { Departure = 3, DepartureTime = "12:00", Destination = 6, DestinationTime = "14:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight128 = new Flight { Departure = 3, DepartureTime = "15:00", Destination = 6, DestinationTime = "17:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight129 = new Flight { Departure = 3, DepartureTime = "18:00", Destination = 6, DestinationTime = "20:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight130 = new Flight { Departure = 3, DepartureTime = "21:00", Destination = 6, DestinationTime = "23:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };

            var Flight131 = new Flight { Departure = 3, DepartureTime = "09:00", Destination = 7, DestinationTime = "11:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight132 = new Flight { Departure = 3, DepartureTime = "12:00", Destination = 7, DestinationTime = "14:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight133 = new Flight { Departure = 3, DepartureTime = "15:00", Destination = 7, DestinationTime = "17:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight134 = new Flight { Departure = 3, DepartureTime = "18:00", Destination = 7, DestinationTime = "20:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight135 = new Flight { Departure = 3, DepartureTime = "21:00", Destination = 7, DestinationTime = "23:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight136 = new Flight { Departure = 3, DepartureTime = "09:00", Destination = 7, DestinationTime = "11:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight137 = new Flight { Departure = 3, DepartureTime = "12:00", Destination = 7, DestinationTime = "14:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight138 = new Flight { Departure = 3, DepartureTime = "15:00", Destination = 7, DestinationTime = "17:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight139 = new Flight { Departure = 3, DepartureTime = "18:00", Destination = 7, DestinationTime = "20:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight140 = new Flight { Departure = 3, DepartureTime = "21:00", Destination = 7, DestinationTime = "23:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };

            var Flight141 = new Flight { Departure = 3, DepartureTime = "08:00", Destination = 8, DestinationTime = "09:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight142 = new Flight { Departure = 3, DepartureTime = "11:00", Destination = 8, DestinationTime = "12:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight143 = new Flight { Departure = 3, DepartureTime = "14:00", Destination = 8, DestinationTime = "15:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight144 = new Flight { Departure = 3, DepartureTime = "17:00", Destination = 8, DestinationTime = "18:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight145 = new Flight { Departure = 3, DepartureTime = "20:00", Destination = 8, DestinationTime = "21:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight146 = new Flight { Departure = 3, DepartureTime = "08:00", Destination = 8, DestinationTime = "09:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight147 = new Flight { Departure = 3, DepartureTime = "11:00", Destination = 8, DestinationTime = "12:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight148 = new Flight { Departure = 3, DepartureTime = "14:00", Destination = 8, DestinationTime = "15:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight149 = new Flight { Departure = 3, DepartureTime = "17:00", Destination = 8, DestinationTime = "18:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight150 = new Flight { Departure = 3, DepartureTime = "20:00", Destination = 8, DestinationTime = "21:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };

            var Flight151 = new Flight { Departure = 4, DepartureTime = "08:00", Destination = 3, DestinationTime = "09:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight152 = new Flight { Departure = 4, DepartureTime = "11:00", Destination = 3, DestinationTime = "12:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight153 = new Flight { Departure = 4, DepartureTime = "14:00", Destination = 3, DestinationTime = "15:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight154 = new Flight { Departure = 4, DepartureTime = "17:00", Destination = 3, DestinationTime = "18:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight155 = new Flight { Departure = 4, DepartureTime = "20:00", Destination = 3, DestinationTime = "21:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight156 = new Flight { Departure = 4, DepartureTime = "08:00", Destination = 3, DestinationTime = "09:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight157 = new Flight { Departure = 4, DepartureTime = "11:00", Destination = 3, DestinationTime = "12:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight158 = new Flight { Departure = 4, DepartureTime = "14:00", Destination = 3, DestinationTime = "15:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight159 = new Flight { Departure = 4, DepartureTime = "17:00", Destination = 3, DestinationTime = "18:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight160 = new Flight { Departure = 4, DepartureTime = "20:00", Destination = 3, DestinationTime = "21:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };

            var Flight161 = new Flight { Departure = 5, DepartureTime = "09:00", Destination = 2, DestinationTime = "11:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight162 = new Flight { Departure = 5, DepartureTime = "12:00", Destination = 2, DestinationTime = "14:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight163 = new Flight { Departure = 5, DepartureTime = "15:00", Destination = 2, DestinationTime = "17:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight164 = new Flight { Departure = 5, DepartureTime = "18:00", Destination = 2, DestinationTime = "20:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight165 = new Flight { Departure = 5, DepartureTime = "21:00", Destination = 2, DestinationTime = "23:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight166 = new Flight { Departure = 5, DepartureTime = "09:00", Destination = 2, DestinationTime = "11:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight167 = new Flight { Departure = 5, DepartureTime = "12:00", Destination = 2, DestinationTime = "14:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight168 = new Flight { Departure = 5, DepartureTime = "15:00", Destination = 2, DestinationTime = "17:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight169 = new Flight { Departure = 5, DepartureTime = "18:00", Destination = 2, DestinationTime = "20:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight170 = new Flight { Departure = 5, DepartureTime = "21:00", Destination = 2, DestinationTime = "23:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };

            var Flight171 = new Flight { Departure = 5, DepartureTime = "08:00", Destination = 3, DestinationTime = "11:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight172 = new Flight { Departure = 5, DepartureTime = "11:00", Destination = 3, DestinationTime = "14:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight173 = new Flight { Departure = 5, DepartureTime = "14:00", Destination = 3, DestinationTime = "17:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight174 = new Flight { Departure = 5, DepartureTime = "17:00", Destination = 3, DestinationTime = "20:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight175 = new Flight { Departure = 5, DepartureTime = "20:00", Destination = 3, DestinationTime = "23:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight176 = new Flight { Departure = 5, DepartureTime = "08:00", Destination = 3, DestinationTime = "11:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight177 = new Flight { Departure = 5, DepartureTime = "11:00", Destination = 3, DestinationTime = "14:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight178 = new Flight { Departure = 5, DepartureTime = "14:00", Destination = 3, DestinationTime = "17:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight179 = new Flight { Departure = 5, DepartureTime = "17:00", Destination = 3, DestinationTime = "20:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight180 = new Flight { Departure = 5, DepartureTime = "20:00", Destination = 3, DestinationTime = "23:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };

            var Flight181 = new Flight { Departure = 5, DepartureTime = "08:00", Destination = 7, DestinationTime = "09:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight182 = new Flight { Departure = 5, DepartureTime = "11:00", Destination = 7, DestinationTime = "12:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight183 = new Flight { Departure = 5, DepartureTime = "14:00", Destination = 7, DestinationTime = "15:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight184 = new Flight { Departure = 5, DepartureTime = "17:00", Destination = 7, DestinationTime = "18:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight185 = new Flight { Departure = 5, DepartureTime = "20:00", Destination = 7, DestinationTime = "21:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight186 = new Flight { Departure = 5, DepartureTime = "08:00", Destination = 7, DestinationTime = "09:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight187 = new Flight { Departure = 5, DepartureTime = "11:00", Destination = 7, DestinationTime = "12:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight188 = new Flight { Departure = 5, DepartureTime = "14:00", Destination = 7, DestinationTime = "15:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight189 = new Flight { Departure = 5, DepartureTime = "17:00", Destination = 7, DestinationTime = "18:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight190 = new Flight { Departure = 5, DepartureTime = "20:00", Destination = 7, DestinationTime = "21:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };

            var Flight191 = new Flight { Departure = 6, DepartureTime = "10:00", Destination = 1, DestinationTime = "11:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight192 = new Flight { Departure = 6, DepartureTime = "13:00", Destination = 1, DestinationTime = "14:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight193 = new Flight { Departure = 6, DepartureTime = "16:00", Destination = 1, DestinationTime = "17:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight194 = new Flight { Departure = 6, DepartureTime = "19:00", Destination = 1, DestinationTime = "20:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight195 = new Flight { Departure = 6, DepartureTime = "22:00", Destination = 1, DestinationTime = "23:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight196 = new Flight { Departure = 6, DepartureTime = "10:00", Destination = 1, DestinationTime = "11:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };
            var Flight197 = new Flight { Departure = 6, DepartureTime = "13:00", Destination = 1, DestinationTime = "14:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };
            var Flight198 = new Flight { Departure = 6, DepartureTime = "16:00", Destination = 1, DestinationTime = "17:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };
            var Flight199 = new Flight { Departure = 6, DepartureTime = "19:00", Destination = 1, DestinationTime = "20:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };
            var Flight200 = new Flight { Departure = 6, DepartureTime = "22:00", Destination = 1, DestinationTime = "23:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };

            var Flight201 = new Flight { Departure = 6, DepartureTime = "09:00", Destination = 3, DestinationTime = "11:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight202 = new Flight { Departure = 6, DepartureTime = "12:00", Destination = 3, DestinationTime = "14:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight203 = new Flight { Departure = 6, DepartureTime = "15:00", Destination = 3, DestinationTime = "17:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight204 = new Flight { Departure = 6, DepartureTime = "18:00", Destination = 3, DestinationTime = "20:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight205 = new Flight { Departure = 6, DepartureTime = "21:00", Destination = 3, DestinationTime = "23:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight206 = new Flight { Departure = 6, DepartureTime = "09:00", Destination = 3, DestinationTime = "11:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight207 = new Flight { Departure = 6, DepartureTime = "12:00", Destination = 3, DestinationTime = "14:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight208 = new Flight { Departure = 6, DepartureTime = "15:00", Destination = 3, DestinationTime = "17:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight209 = new Flight { Departure = 6, DepartureTime = "18:00", Destination = 3, DestinationTime = "20:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight210 = new Flight { Departure = 6, DepartureTime = "21:00", Destination = 3, DestinationTime = "23:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };

            var Flight211 = new Flight { Departure = 7, DepartureTime = "10:00", Destination = 1, DestinationTime = "11:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight212 = new Flight { Departure = 7, DepartureTime = "13:00", Destination = 1, DestinationTime = "14:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight213 = new Flight { Departure = 7, DepartureTime = "16:00", Destination = 1, DestinationTime = "17:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight214 = new Flight { Departure = 7, DepartureTime = "19:00", Destination = 1, DestinationTime = "20:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight215 = new Flight { Departure = 7, DepartureTime = "22:00", Destination = 1, DestinationTime = "23:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight216 = new Flight { Departure = 7, DepartureTime = "10:00", Destination = 1, DestinationTime = "11:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };
            var Flight217 = new Flight { Departure = 7, DepartureTime = "13:00", Destination = 1, DestinationTime = "14:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };
            var Flight218 = new Flight { Departure = 7, DepartureTime = "16:00", Destination = 1, DestinationTime = "17:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };
            var Flight219 = new Flight { Departure = 7, DepartureTime = "19:00", Destination = 1, DestinationTime = "20:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };
            var Flight220 = new Flight { Departure = 7, DepartureTime = "22:00", Destination = 1, DestinationTime = "23:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };

            var Flight221 = new Flight { Departure = 7, DepartureTime = "09:00", Destination = 2, DestinationTime = "11:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight222 = new Flight { Departure = 7, DepartureTime = "12:00", Destination = 2, DestinationTime = "14:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight223 = new Flight { Departure = 7, DepartureTime = "15:00", Destination = 2, DestinationTime = "17:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight224 = new Flight { Departure = 7, DepartureTime = "18:00", Destination = 2, DestinationTime = "20:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight225 = new Flight { Departure = 7, DepartureTime = "21:00", Destination = 2, DestinationTime = "23:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight226 = new Flight { Departure = 7, DepartureTime = "09:00", Destination = 2, DestinationTime = "11:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight227 = new Flight { Departure = 7, DepartureTime = "12:00", Destination = 2, DestinationTime = "14:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight228 = new Flight { Departure = 7, DepartureTime = "15:00", Destination = 2, DestinationTime = "17:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight229 = new Flight { Departure = 7, DepartureTime = "18:00", Destination = 2, DestinationTime = "20:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight230 = new Flight { Departure = 7, DepartureTime = "21:00", Destination = 2, DestinationTime = "23:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };

            var Flight231 = new Flight { Departure = 7, DepartureTime = "09:00", Destination = 3, DestinationTime = "11:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight232 = new Flight { Departure = 7, DepartureTime = "12:00", Destination = 3, DestinationTime = "14:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight233 = new Flight { Departure = 7, DepartureTime = "15:00", Destination = 3, DestinationTime = "17:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight234 = new Flight { Departure = 7, DepartureTime = "18:00", Destination = 3, DestinationTime = "20:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight235 = new Flight { Departure = 7, DepartureTime = "21:00", Destination = 3, DestinationTime = "23:30", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight236 = new Flight { Departure = 7, DepartureTime = "09:00", Destination = 3, DestinationTime = "11:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight237 = new Flight { Departure = 7, DepartureTime = "12:00", Destination = 3, DestinationTime = "14:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight238 = new Flight { Departure = 7, DepartureTime = "15:00", Destination = 3, DestinationTime = "17:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight239 = new Flight { Departure = 7, DepartureTime = "18:00", Destination = 3, DestinationTime = "20:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight240 = new Flight { Departure = 7, DepartureTime = "21:00", Destination = 3, DestinationTime = "23:30", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };

            var Flight241 = new Flight { Departure = 7, DepartureTime = "08:00", Destination = 5, DestinationTime = "09:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight242 = new Flight { Departure = 7, DepartureTime = "11:00", Destination = 5, DestinationTime = "12:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight243 = new Flight { Departure = 7, DepartureTime = "14:00", Destination = 5, DestinationTime = "15:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight244 = new Flight { Departure = 7, DepartureTime = "17:00", Destination = 5, DestinationTime = "18:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight245 = new Flight { Departure = 7, DepartureTime = "20:00", Destination = 5, DestinationTime = "21:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight246 = new Flight { Departure = 7, DepartureTime = "08:00", Destination = 5, DestinationTime = "09:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight247 = new Flight { Departure = 7, DepartureTime = "11:00", Destination = 5, DestinationTime = "12:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight248 = new Flight { Departure = 7, DepartureTime = "14:00", Destination = 5, DestinationTime = "15:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight249 = new Flight { Departure = 7, DepartureTime = "17:00", Destination = 5, DestinationTime = "18:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight250 = new Flight { Departure = 7, DepartureTime = "20:00", Destination = 5, DestinationTime = "21:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };

            var Flight251 = new Flight { Departure = 8, DepartureTime = "08:00", Destination = 3, DestinationTime = "09:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight252 = new Flight { Departure = 8, DepartureTime = "11:00", Destination = 3, DestinationTime = "12:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight253 = new Flight { Departure = 8, DepartureTime = "14:00", Destination = 3, DestinationTime = "15:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight254 = new Flight { Departure = 8, DepartureTime = "17:00", Destination = 3, DestinationTime = "18:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight255 = new Flight { Departure = 8, DepartureTime = "20:00", Destination = 3, DestinationTime = "21:00", TravelDate = "09/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight256 = new Flight { Departure = 8, DepartureTime = "08:00", Destination = 3, DestinationTime = "09:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight257 = new Flight { Departure = 8, DepartureTime = "11:00", Destination = 3, DestinationTime = "12:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight258 = new Flight { Departure = 8, DepartureTime = "14:00", Destination = 3, DestinationTime = "15:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight259 = new Flight { Departure = 8, DepartureTime = "17:00", Destination = 3, DestinationTime = "18:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight260 = new Flight { Departure = 8, DepartureTime = "20:00", Destination = 3, DestinationTime = "21:00", TravelDate = "09/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };


            var Flight261 = new Flight { Departure = 1, DepartureTime = "09:00", Destination = 2, DestinationTime = "11:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight262 = new Flight { Departure = 1, DepartureTime = "12:00", Destination = 2, DestinationTime = "14:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight263 = new Flight { Departure = 1, DepartureTime = "15:00", Destination = 2, DestinationTime = "17:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight264 = new Flight { Departure = 1, DepartureTime = "18:00", Destination = 2, DestinationTime = "20:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight265 = new Flight { Departure = 1, DepartureTime = "21:00", Destination = 2, DestinationTime = "23:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight266 = new Flight { Departure = 1, DepartureTime = "09:00", Destination = 2, DestinationTime = "11:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight267 = new Flight { Departure = 1, DepartureTime = "12:00", Destination = 2, DestinationTime = "14:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight268 = new Flight { Departure = 1, DepartureTime = "15:00", Destination = 2, DestinationTime = "17:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight269 = new Flight { Departure = 1, DepartureTime = "18:00", Destination = 2, DestinationTime = "20:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight270 = new Flight { Departure = 1, DepartureTime = "21:00", Destination = 2, DestinationTime = "23:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };

            var Flight271 = new Flight { Departure = 1, DepartureTime = "09:00", Destination = 3, DestinationTime = "11:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1200 };
            var Flight272 = new Flight { Departure = 1, DepartureTime = "12:00", Destination = 3, DestinationTime = "14:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1200 };
            var Flight273 = new Flight { Departure = 1, DepartureTime = "15:00", Destination = 3, DestinationTime = "18:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1200 };
            var Flight274 = new Flight { Departure = 1, DepartureTime = "18:00", Destination = 3, DestinationTime = "20:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1200 };
            var Flight275 = new Flight { Departure = 1, DepartureTime = "21:00", Destination = 3, DestinationTime = "23:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1200 };
            var Flight276 = new Flight { Departure = 1, DepartureTime = "09:00", Destination = 3, DestinationTime = "11:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2500 };
            var Flight277 = new Flight { Departure = 1, DepartureTime = "12:00", Destination = 3, DestinationTime = "14:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2500 };
            var Flight278 = new Flight { Departure = 1, DepartureTime = "15:00", Destination = 3, DestinationTime = "17:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2500 };
            var Flight279 = new Flight { Departure = 1, DepartureTime = "18:00", Destination = 3, DestinationTime = "20:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2500 };
            var Flight280 = new Flight { Departure = 1, DepartureTime = "21:00", Destination = 3, DestinationTime = "23:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2500 };

            var Flight281 = new Flight { Departure = 1, DepartureTime = "10:00", Destination = 6, DestinationTime = "11:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight282 = new Flight { Departure = 1, DepartureTime = "13:00", Destination = 6, DestinationTime = "14:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight283 = new Flight { Departure = 1, DepartureTime = "16:00", Destination = 6, DestinationTime = "17:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight284 = new Flight { Departure = 1, DepartureTime = "19:00", Destination = 6, DestinationTime = "20:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight285 = new Flight { Departure = 1, DepartureTime = "22:00", Destination = 6, DestinationTime = "23:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight286 = new Flight { Departure = 1, DepartureTime = "10:00", Destination = 6, DestinationTime = "11:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };
            var Flight287 = new Flight { Departure = 1, DepartureTime = "13:00", Destination = 6, DestinationTime = "14:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };
            var Flight288 = new Flight { Departure = 1, DepartureTime = "16:00", Destination = 6, DestinationTime = "17:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };
            var Flight289 = new Flight { Departure = 1, DepartureTime = "19:00", Destination = 6, DestinationTime = "20:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };
            var Flight290 = new Flight { Departure = 1, DepartureTime = "22:00", Destination = 6, DestinationTime = "23:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };

            var Flight291 = new Flight { Departure = 1, DepartureTime = "10:00", Destination = 7, DestinationTime = "11:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight292 = new Flight { Departure = 1, DepartureTime = "13:00", Destination = 7, DestinationTime = "14:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight293 = new Flight { Departure = 1, DepartureTime = "16:00", Destination = 7, DestinationTime = "17:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight294 = new Flight { Departure = 1, DepartureTime = "19:00", Destination = 7, DestinationTime = "20:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight295 = new Flight { Departure = 1, DepartureTime = "22:00", Destination = 7, DestinationTime = "23:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight296 = new Flight { Departure = 1, DepartureTime = "10:00", Destination = 7, DestinationTime = "11:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };
            var Flight297 = new Flight { Departure = 1, DepartureTime = "13:00", Destination = 7, DestinationTime = "14:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };
            var Flight298 = new Flight { Departure = 1, DepartureTime = "16:00", Destination = 7, DestinationTime = "17:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };
            var Flight299 = new Flight { Departure = 1, DepartureTime = "19:00", Destination = 7, DestinationTime = "20:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };
            var Flight300 = new Flight { Departure = 1, DepartureTime = "22:00", Destination = 7, DestinationTime = "23:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };

            var Flight301 = new Flight { Departure = 2, DepartureTime = "09:00", Destination = 1, DestinationTime = "11:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight302 = new Flight { Departure = 2, DepartureTime = "12:00", Destination = 1, DestinationTime = "14:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight303 = new Flight { Departure = 2, DepartureTime = "15:00", Destination = 1, DestinationTime = "17:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight304 = new Flight { Departure = 2, DepartureTime = "18:00", Destination = 1, DestinationTime = "20:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight305 = new Flight { Departure = 2, DepartureTime = "21:00", Destination = 1, DestinationTime = "23:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight306 = new Flight { Departure = 2, DepartureTime = "09:00", Destination = 1, DestinationTime = "11:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight307 = new Flight { Departure = 2, DepartureTime = "12:00", Destination = 1, DestinationTime = "14:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight308 = new Flight { Departure = 2, DepartureTime = "15:00", Destination = 1, DestinationTime = "17:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight309 = new Flight { Departure = 2, DepartureTime = "18:00", Destination = 1, DestinationTime = "20:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight310 = new Flight { Departure = 2, DepartureTime = "21:00", Destination = 1, DestinationTime = "23:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };

            var Flight311 = new Flight { Departure = 2, DepartureTime = "09:00", Destination = 3, DestinationTime = "10:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1000 };
            var Flight312 = new Flight { Departure = 2, DepartureTime = "12:00", Destination = 3, DestinationTime = "13:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1000 };
            var Flight313 = new Flight { Departure = 2, DepartureTime = "15:00", Destination = 3, DestinationTime = "16:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1000 };
            var Flight314 = new Flight { Departure = 2, DepartureTime = "18:00", Destination = 3, DestinationTime = "17:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1000 };
            var Flight315 = new Flight { Departure = 2, DepartureTime = "21:00", Destination = 3, DestinationTime = "22:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1000 };
            var Flight316 = new Flight { Departure = 2, DepartureTime = "09:00", Destination = 3, DestinationTime = "10:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2200 };
            var Flight317 = new Flight { Departure = 2, DepartureTime = "12:00", Destination = 3, DestinationTime = "13:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2200 };
            var Flight318 = new Flight { Departure = 2, DepartureTime = "15:00", Destination = 3, DestinationTime = "16:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2200 };
            var Flight319 = new Flight { Departure = 2, DepartureTime = "18:00", Destination = 3, DestinationTime = "19:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2200 };
            var Flight320 = new Flight { Departure = 2, DepartureTime = "21:00", Destination = 3, DestinationTime = "22:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2200 };

            var Flight321 = new Flight { Departure = 2, DepartureTime = "09:00", Destination = 5, DestinationTime = "11:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight322 = new Flight { Departure = 2, DepartureTime = "12:00", Destination = 5, DestinationTime = "14:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight323 = new Flight { Departure = 2, DepartureTime = "15:00", Destination = 5, DestinationTime = "17:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight324 = new Flight { Departure = 2, DepartureTime = "18:00", Destination = 5, DestinationTime = "20:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight325 = new Flight { Departure = 2, DepartureTime = "21:00", Destination = 5, DestinationTime = "23:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight326 = new Flight { Departure = 2, DepartureTime = "09:00", Destination = 5, DestinationTime = "11:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight327 = new Flight { Departure = 2, DepartureTime = "12:00", Destination = 5, DestinationTime = "14:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight328 = new Flight { Departure = 2, DepartureTime = "15:00", Destination = 5, DestinationTime = "17:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight329 = new Flight { Departure = 2, DepartureTime = "18:00", Destination = 5, DestinationTime = "20:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight330 = new Flight { Departure = 2, DepartureTime = "21:00", Destination = 5, DestinationTime = "23:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };

            var Flight331 = new Flight { Departure = 2, DepartureTime = "09:00", Destination = 7, DestinationTime = "11:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight332 = new Flight { Departure = 2, DepartureTime = "12:00", Destination = 7, DestinationTime = "14:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight333 = new Flight { Departure = 2, DepartureTime = "15:00", Destination = 7, DestinationTime = "17:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight334 = new Flight { Departure = 2, DepartureTime = "18:00", Destination = 7, DestinationTime = "20:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight335 = new Flight { Departure = 2, DepartureTime = "21:00", Destination = 7, DestinationTime = "23:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight336 = new Flight { Departure = 2, DepartureTime = "09:00", Destination = 7, DestinationTime = "11:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight337 = new Flight { Departure = 2, DepartureTime = "12:00", Destination = 7, DestinationTime = "14:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight338 = new Flight { Departure = 2, DepartureTime = "15:00", Destination = 7, DestinationTime = "17:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight339 = new Flight { Departure = 2, DepartureTime = "18:00", Destination = 7, DestinationTime = "20:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight340 = new Flight { Departure = 2, DepartureTime = "21:00", Destination = 7, DestinationTime = "23:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };

            var Flight341 = new Flight { Departure = 3, DepartureTime = "09:00", Destination = 1, DestinationTime = "11:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1200 };
            var Flight342 = new Flight { Departure = 3, DepartureTime = "12:00", Destination = 1, DestinationTime = "14:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1200 };
            var Flight343 = new Flight { Departure = 3, DepartureTime = "15:00", Destination = 1, DestinationTime = "18:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1200 };
            var Flight344 = new Flight { Departure = 3, DepartureTime = "18:00", Destination = 1, DestinationTime = "20:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1200 };
            var Flight345 = new Flight { Departure = 3, DepartureTime = "21:00", Destination = 1, DestinationTime = "23:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1200 };
            var Flight346 = new Flight { Departure = 3, DepartureTime = "09:00", Destination = 1, DestinationTime = "11:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2500 };
            var Flight347 = new Flight { Departure = 3, DepartureTime = "12:00", Destination = 1, DestinationTime = "14:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2500 };
            var Flight348 = new Flight { Departure = 3, DepartureTime = "15:00", Destination = 1, DestinationTime = "17:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2500 };
            var Flight349 = new Flight { Departure = 3, DepartureTime = "18:00", Destination = 1, DestinationTime = "20:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2500 };
            var Flight350 = new Flight { Departure = 3, DepartureTime = "21:00", Destination = 1, DestinationTime = "23:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2500 };

            var Flight351 = new Flight { Departure = 3, DepartureTime = "09:00", Destination = 2, DestinationTime = "10:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1000 };
            var Flight352 = new Flight { Departure = 3, DepartureTime = "12:00", Destination = 2, DestinationTime = "13:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1000 };
            var Flight353 = new Flight { Departure = 3, DepartureTime = "15:00", Destination = 2, DestinationTime = "16:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1000 };
            var Flight354 = new Flight { Departure = 3, DepartureTime = "18:00", Destination = 2, DestinationTime = "17:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1000 };
            var Flight355 = new Flight { Departure = 3, DepartureTime = "21:00", Destination = 2, DestinationTime = "22:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1000 };
            var Flight356 = new Flight { Departure = 3, DepartureTime = "09:00", Destination = 2, DestinationTime = "10:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2200 };
            var Flight357 = new Flight { Departure = 3, DepartureTime = "12:00", Destination = 2, DestinationTime = "13:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2200 };
            var Flight358 = new Flight { Departure = 3, DepartureTime = "15:00", Destination = 2, DestinationTime = "16:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2200 };
            var Flight359 = new Flight { Departure = 3, DepartureTime = "18:00", Destination = 2, DestinationTime = "19:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2200 };
            var Flight360 = new Flight { Departure = 3, DepartureTime = "21:00", Destination = 3, DestinationTime = "22:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2200 };

            var Flight361 = new Flight { Departure = 3, DepartureTime = "08:00", Destination = 4, DestinationTime = "09:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight362 = new Flight { Departure = 3, DepartureTime = "11:00", Destination = 4, DestinationTime = "12:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight363 = new Flight { Departure = 3, DepartureTime = "14:00", Destination = 4, DestinationTime = "15:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight364 = new Flight { Departure = 3, DepartureTime = "17:00", Destination = 4, DestinationTime = "18:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight365 = new Flight { Departure = 3, DepartureTime = "20:00", Destination = 4, DestinationTime = "21:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight366 = new Flight { Departure = 3, DepartureTime = "08:00", Destination = 4, DestinationTime = "09:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight367 = new Flight { Departure = 3, DepartureTime = "11:00", Destination = 4, DestinationTime = "12:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight368 = new Flight { Departure = 3, DepartureTime = "14:00", Destination = 4, DestinationTime = "15:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight369 = new Flight { Departure = 3, DepartureTime = "17:00", Destination = 4, DestinationTime = "18:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight370 = new Flight { Departure = 3, DepartureTime = "20:00", Destination = 4, DestinationTime = "21:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };

            var Flight371 = new Flight { Departure = 3, DepartureTime = "08:00", Destination = 5, DestinationTime = "11:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight372 = new Flight { Departure = 3, DepartureTime = "11:00", Destination = 5, DestinationTime = "14:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight373 = new Flight { Departure = 3, DepartureTime = "14:00", Destination = 5, DestinationTime = "17:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight374 = new Flight { Departure = 3, DepartureTime = "17:00", Destination = 5, DestinationTime = "20:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight375 = new Flight { Departure = 3, DepartureTime = "20:00", Destination = 5, DestinationTime = "23:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight376 = new Flight { Departure = 3, DepartureTime = "08:00", Destination = 5, DestinationTime = "11:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight377 = new Flight { Departure = 3, DepartureTime = "11:00", Destination = 5, DestinationTime = "14:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight378 = new Flight { Departure = 3, DepartureTime = "14:00", Destination = 5, DestinationTime = "17:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight379 = new Flight { Departure = 3, DepartureTime = "17:00", Destination = 5, DestinationTime = "20:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight380 = new Flight { Departure = 3, DepartureTime = "20:00", Destination = 5, DestinationTime = "23:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };

            var Flight381 = new Flight { Departure = 3, DepartureTime = "09:00", Destination = 6, DestinationTime = "11:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight382 = new Flight { Departure = 3, DepartureTime = "12:00", Destination = 6, DestinationTime = "14:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight383 = new Flight { Departure = 3, DepartureTime = "15:00", Destination = 6, DestinationTime = "17:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight384 = new Flight { Departure = 3, DepartureTime = "18:00", Destination = 6, DestinationTime = "20:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight385 = new Flight { Departure = 3, DepartureTime = "21:00", Destination = 6, DestinationTime = "23:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight386 = new Flight { Departure = 3, DepartureTime = "09:00", Destination = 6, DestinationTime = "11:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight387 = new Flight { Departure = 3, DepartureTime = "12:00", Destination = 6, DestinationTime = "14:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight388 = new Flight { Departure = 3, DepartureTime = "15:00", Destination = 6, DestinationTime = "17:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight389 = new Flight { Departure = 3, DepartureTime = "18:00", Destination = 6, DestinationTime = "20:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight390 = new Flight { Departure = 3, DepartureTime = "21:00", Destination = 6, DestinationTime = "23:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };

            var Flight391 = new Flight { Departure = 3, DepartureTime = "09:00", Destination = 7, DestinationTime = "11:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight392 = new Flight { Departure = 3, DepartureTime = "12:00", Destination = 7, DestinationTime = "14:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight393 = new Flight { Departure = 3, DepartureTime = "15:00", Destination = 7, DestinationTime = "17:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight394 = new Flight { Departure = 3, DepartureTime = "18:00", Destination = 7, DestinationTime = "20:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight395 = new Flight { Departure = 3, DepartureTime = "21:00", Destination = 7, DestinationTime = "23:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight396 = new Flight { Departure = 3, DepartureTime = "09:00", Destination = 7, DestinationTime = "11:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight397 = new Flight { Departure = 3, DepartureTime = "12:00", Destination = 7, DestinationTime = "14:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight398 = new Flight { Departure = 3, DepartureTime = "15:00", Destination = 7, DestinationTime = "17:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight399 = new Flight { Departure = 3, DepartureTime = "18:00", Destination = 7, DestinationTime = "20:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight400 = new Flight { Departure = 3, DepartureTime = "21:00", Destination = 7, DestinationTime = "23:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };

            var Flight401 = new Flight { Departure = 3, DepartureTime = "08:00", Destination = 8, DestinationTime = "09:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight402 = new Flight { Departure = 3, DepartureTime = "11:00", Destination = 8, DestinationTime = "12:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight403 = new Flight { Departure = 3, DepartureTime = "14:00", Destination = 8, DestinationTime = "15:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight404 = new Flight { Departure = 3, DepartureTime = "17:00", Destination = 8, DestinationTime = "18:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight405 = new Flight { Departure = 3, DepartureTime = "20:00", Destination = 8, DestinationTime = "21:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight406 = new Flight { Departure = 3, DepartureTime = "08:00", Destination = 8, DestinationTime = "09:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight407 = new Flight { Departure = 3, DepartureTime = "11:00", Destination = 8, DestinationTime = "12:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight408 = new Flight { Departure = 3, DepartureTime = "14:00", Destination = 8, DestinationTime = "15:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight409 = new Flight { Departure = 3, DepartureTime = "17:00", Destination = 8, DestinationTime = "18:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight410 = new Flight { Departure = 3, DepartureTime = "20:00", Destination = 8, DestinationTime = "21:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };


            var Flight411 = new Flight { Departure = 4, DepartureTime = "08:00", Destination = 3, DestinationTime = "09:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight412 = new Flight { Departure = 4, DepartureTime = "11:00", Destination = 3, DestinationTime = "12:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight413 = new Flight { Departure = 4, DepartureTime = "14:00", Destination = 3, DestinationTime = "15:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight414 = new Flight { Departure = 4, DepartureTime = "17:00", Destination = 3, DestinationTime = "18:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight415 = new Flight { Departure = 4, DepartureTime = "20:00", Destination = 3, DestinationTime = "21:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight416 = new Flight { Departure = 4, DepartureTime = "08:00", Destination = 3, DestinationTime = "09:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight417 = new Flight { Departure = 4, DepartureTime = "11:00", Destination = 3, DestinationTime = "12:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight418 = new Flight { Departure = 4, DepartureTime = "14:00", Destination = 3, DestinationTime = "15:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight419 = new Flight { Departure = 4, DepartureTime = "17:00", Destination = 3, DestinationTime = "18:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight420 = new Flight { Departure = 4, DepartureTime = "20:00", Destination = 3, DestinationTime = "21:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };

            var Flight421 = new Flight { Departure = 5, DepartureTime = "09:00", Destination = 2, DestinationTime = "11:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight422 = new Flight { Departure = 5, DepartureTime = "12:00", Destination = 2, DestinationTime = "14:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight423 = new Flight { Departure = 5, DepartureTime = "15:00", Destination = 2, DestinationTime = "17:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight424 = new Flight { Departure = 5, DepartureTime = "18:00", Destination = 2, DestinationTime = "20:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight425 = new Flight { Departure = 5, DepartureTime = "21:00", Destination = 2, DestinationTime = "23:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight426 = new Flight { Departure = 5, DepartureTime = "09:00", Destination = 2, DestinationTime = "11:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight427 = new Flight { Departure = 5, DepartureTime = "12:00", Destination = 2, DestinationTime = "14:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight428 = new Flight { Departure = 5, DepartureTime = "15:00", Destination = 2, DestinationTime = "17:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight429 = new Flight { Departure = 5, DepartureTime = "18:00", Destination = 2, DestinationTime = "20:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight430 = new Flight { Departure = 5, DepartureTime = "21:00", Destination = 2, DestinationTime = "23:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };

            var Flight431 = new Flight { Departure = 5, DepartureTime = "08:00", Destination = 3, DestinationTime = "11:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight432 = new Flight { Departure = 5, DepartureTime = "11:00", Destination = 3, DestinationTime = "14:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight433 = new Flight { Departure = 5, DepartureTime = "14:00", Destination = 3, DestinationTime = "17:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight434 = new Flight { Departure = 5, DepartureTime = "17:00", Destination = 3, DestinationTime = "20:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight435 = new Flight { Departure = 5, DepartureTime = "20:00", Destination = 3, DestinationTime = "23:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight436 = new Flight { Departure = 5, DepartureTime = "08:00", Destination = 3, DestinationTime = "11:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight437 = new Flight { Departure = 5, DepartureTime = "11:00", Destination = 3, DestinationTime = "14:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight438 = new Flight { Departure = 5, DepartureTime = "14:00", Destination = 3, DestinationTime = "17:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight439 = new Flight { Departure = 5, DepartureTime = "17:00", Destination = 3, DestinationTime = "20:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight440 = new Flight { Departure = 5, DepartureTime = "20:00", Destination = 3, DestinationTime = "23:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };

            var Flight441 = new Flight { Departure = 5, DepartureTime = "08:00", Destination = 7, DestinationTime = "09:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight442 = new Flight { Departure = 5, DepartureTime = "11:00", Destination = 7, DestinationTime = "12:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight443 = new Flight { Departure = 5, DepartureTime = "14:00", Destination = 7, DestinationTime = "15:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight444 = new Flight { Departure = 5, DepartureTime = "17:00", Destination = 7, DestinationTime = "18:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight445 = new Flight { Departure = 5, DepartureTime = "20:00", Destination = 7, DestinationTime = "21:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight446 = new Flight { Departure = 5, DepartureTime = "08:00", Destination = 7, DestinationTime = "09:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight447 = new Flight { Departure = 5, DepartureTime = "11:00", Destination = 7, DestinationTime = "12:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight448 = new Flight { Departure = 5, DepartureTime = "14:00", Destination = 7, DestinationTime = "15:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight449 = new Flight { Departure = 5, DepartureTime = "17:00", Destination = 7, DestinationTime = "18:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight450 = new Flight { Departure = 5, DepartureTime = "20:00", Destination = 7, DestinationTime = "21:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };

            var Flight451 = new Flight { Departure = 6, DepartureTime = "10:00", Destination = 1, DestinationTime = "11:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight452 = new Flight { Departure = 6, DepartureTime = "13:00", Destination = 1, DestinationTime = "14:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight453 = new Flight { Departure = 6, DepartureTime = "16:00", Destination = 1, DestinationTime = "17:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight454 = new Flight { Departure = 6, DepartureTime = "19:00", Destination = 1, DestinationTime = "20:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight455 = new Flight { Departure = 6, DepartureTime = "22:00", Destination = 1, DestinationTime = "23:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight456 = new Flight { Departure = 6, DepartureTime = "10:00", Destination = 1, DestinationTime = "11:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };
            var Flight457 = new Flight { Departure = 6, DepartureTime = "13:00", Destination = 1, DestinationTime = "14:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };
            var Flight458 = new Flight { Departure = 6, DepartureTime = "16:00", Destination = 1, DestinationTime = "17:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };
            var Flight459 = new Flight { Departure = 6, DepartureTime = "19:00", Destination = 1, DestinationTime = "20:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };
            var Flight460 = new Flight { Departure = 6, DepartureTime = "22:00", Destination = 1, DestinationTime = "23:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };

            var Flight461 = new Flight { Departure = 6, DepartureTime = "09:00", Destination = 3, DestinationTime = "11:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight462 = new Flight { Departure = 6, DepartureTime = "12:00", Destination = 3, DestinationTime = "14:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight463 = new Flight { Departure = 6, DepartureTime = "15:00", Destination = 3, DestinationTime = "17:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight464 = new Flight { Departure = 6, DepartureTime = "18:00", Destination = 3, DestinationTime = "20:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight465 = new Flight { Departure = 6, DepartureTime = "21:00", Destination = 3, DestinationTime = "23:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight466 = new Flight { Departure = 6, DepartureTime = "09:00", Destination = 3, DestinationTime = "11:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight467 = new Flight { Departure = 6, DepartureTime = "12:00", Destination = 3, DestinationTime = "14:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight468 = new Flight { Departure = 6, DepartureTime = "15:00", Destination = 3, DestinationTime = "17:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight469 = new Flight { Departure = 6, DepartureTime = "18:00", Destination = 3, DestinationTime = "20:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight470 = new Flight { Departure = 6, DepartureTime = "21:00", Destination = 3, DestinationTime = "23:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };

            var Flight471 = new Flight { Departure = 7, DepartureTime = "10:00", Destination = 1, DestinationTime = "11:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight472 = new Flight { Departure = 7, DepartureTime = "13:00", Destination = 1, DestinationTime = "14:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight473 = new Flight { Departure = 7, DepartureTime = "16:00", Destination = 1, DestinationTime = "17:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight474 = new Flight { Departure = 7, DepartureTime = "19:00", Destination = 1, DestinationTime = "20:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight475 = new Flight { Departure = 7, DepartureTime = "22:00", Destination = 1, DestinationTime = "23:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1350 };
            var Flight476 = new Flight { Departure = 7, DepartureTime = "10:00", Destination = 1, DestinationTime = "11:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };
            var Flight477 = new Flight { Departure = 7, DepartureTime = "13:00", Destination = 1, DestinationTime = "14:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };
            var Flight478 = new Flight { Departure = 7, DepartureTime = "16:00", Destination = 1, DestinationTime = "17:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };
            var Flight479 = new Flight { Departure = 7, DepartureTime = "19:00", Destination = 1, DestinationTime = "20:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };
            var Flight480 = new Flight { Departure = 7, DepartureTime = "22:00", Destination = 1, DestinationTime = "23:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2800 };

            var Flight481 = new Flight { Departure = 7, DepartureTime = "09:00", Destination = 2, DestinationTime = "11:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight482 = new Flight { Departure = 7, DepartureTime = "12:00", Destination = 2, DestinationTime = "14:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight483 = new Flight { Departure = 7, DepartureTime = "15:00", Destination = 2, DestinationTime = "17:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight484 = new Flight { Departure = 7, DepartureTime = "18:00", Destination = 2, DestinationTime = "20:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight485 = new Flight { Departure = 7, DepartureTime = "21:00", Destination = 2, DestinationTime = "23:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1500 };
            var Flight486 = new Flight { Departure = 7, DepartureTime = "09:00", Destination = 2, DestinationTime = "11:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight487 = new Flight { Departure = 7, DepartureTime = "12:00", Destination = 2, DestinationTime = "14:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight488 = new Flight { Departure = 7, DepartureTime = "15:00", Destination = 2, DestinationTime = "17:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight489 = new Flight { Departure = 7, DepartureTime = "18:00", Destination = 2, DestinationTime = "20:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };
            var Flight490 = new Flight { Departure = 7, DepartureTime = "21:00", Destination = 2, DestinationTime = "23:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 3000 };

            var Flight491 = new Flight { Departure = 7, DepartureTime = "09:00", Destination = 3, DestinationTime = "11:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight492 = new Flight { Departure = 7, DepartureTime = "12:00", Destination = 3, DestinationTime = "14:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight493 = new Flight { Departure = 7, DepartureTime = "15:00", Destination = 3, DestinationTime = "17:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight494 = new Flight { Departure = 7, DepartureTime = "18:00", Destination = 3, DestinationTime = "20:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight495 = new Flight { Departure = 7, DepartureTime = "21:00", Destination = 3, DestinationTime = "23:30", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight496 = new Flight { Departure = 7, DepartureTime = "09:00", Destination = 3, DestinationTime = "11:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight497 = new Flight { Departure = 7, DepartureTime = "12:00", Destination = 3, DestinationTime = "14:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight498 = new Flight { Departure = 7, DepartureTime = "15:00", Destination = 3, DestinationTime = "17:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight499 = new Flight { Departure = 7, DepartureTime = "18:00", Destination = 3, DestinationTime = "20:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight500 = new Flight { Departure = 7, DepartureTime = "21:00", Destination = 3, DestinationTime = "23:30", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };

            var Flight501 = new Flight { Departure = 7, DepartureTime = "08:00", Destination = 5, DestinationTime = "09:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight502 = new Flight { Departure = 7, DepartureTime = "11:00", Destination = 5, DestinationTime = "12:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight503 = new Flight { Departure = 7, DepartureTime = "14:00", Destination = 5, DestinationTime = "15:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight504 = new Flight { Departure = 7, DepartureTime = "17:00", Destination = 5, DestinationTime = "18:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight505 = new Flight { Departure = 7, DepartureTime = "20:00", Destination = 5, DestinationTime = "21:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight506 = new Flight { Departure = 7, DepartureTime = "08:00", Destination = 5, DestinationTime = "09:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight507 = new Flight { Departure = 7, DepartureTime = "11:00", Destination = 5, DestinationTime = "12:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight508 = new Flight { Departure = 7, DepartureTime = "14:00", Destination = 5, DestinationTime = "15:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight509 = new Flight { Departure = 7, DepartureTime = "17:00", Destination = 5, DestinationTime = "18:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight510 = new Flight { Departure = 7, DepartureTime = "20:00", Destination = 5, DestinationTime = "21:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };

            var Flight511 = new Flight { Departure = 8, DepartureTime = "08:00", Destination = 3, DestinationTime = "09:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight512 = new Flight { Departure = 8, DepartureTime = "11:00", Destination = 3, DestinationTime = "12:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight513 = new Flight { Departure = 8, DepartureTime = "14:00", Destination = 3, DestinationTime = "15:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight514 = new Flight { Departure = 8, DepartureTime = "17:00", Destination = 3, DestinationTime = "18:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight515 = new Flight { Departure = 8, DepartureTime = "20:00", Destination = 3, DestinationTime = "21:00", TravelDate = "15/10/2017", ClassType = "Økonomi", Seats = 50, Price = 1150 };
            var Flight516 = new Flight { Departure = 8, DepartureTime = "08:00", Destination = 3, DestinationTime = "09:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight517 = new Flight { Departure = 8, DepartureTime = "11:00", Destination = 3, DestinationTime = "12:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight518 = new Flight { Departure = 8, DepartureTime = "14:00", Destination = 3, DestinationTime = "15:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight519 = new Flight { Departure = 8, DepartureTime = "17:00", Destination = 3, DestinationTime = "18:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };
            var Flight520 = new Flight { Departure = 8, DepartureTime = "20:00", Destination = 3, DestinationTime = "21:00", TravelDate = "15/10/2017", ClassType = "Business", Seats = 50, Price = 2300 };



            db.Flight.Add(Flight1);
            db.Flight.Add(Flight2);
            db.Flight.Add(Flight3);
            db.Flight.Add(Flight4);
            db.Flight.Add(Flight5);
            db.Flight.Add(Flight6);
            db.Flight.Add(Flight7);
            db.Flight.Add(Flight8);
            db.Flight.Add(Flight9);
            db.Flight.Add(Flight10);
            db.Flight.Add(Flight11);
            db.Flight.Add(Flight12);
            db.Flight.Add(Flight13);
            db.Flight.Add(Flight14);
            db.Flight.Add(Flight15);
            db.Flight.Add(Flight16);
            db.Flight.Add(Flight17);
            db.Flight.Add(Flight18);
            db.Flight.Add(Flight19);
            db.Flight.Add(Flight20);
            db.Flight.Add(Flight21);
            db.Flight.Add(Flight22);
            db.Flight.Add(Flight23);
            db.Flight.Add(Flight24);
            db.Flight.Add(Flight25);
            db.Flight.Add(Flight26);
            db.Flight.Add(Flight27);
            db.Flight.Add(Flight28);
            db.Flight.Add(Flight29);
            db.Flight.Add(Flight30);
            db.Flight.Add(Flight31);
            db.Flight.Add(Flight32);
            db.Flight.Add(Flight33);
            db.Flight.Add(Flight34);
            db.Flight.Add(Flight35);
            db.Flight.Add(Flight36);
            db.Flight.Add(Flight37);
            db.Flight.Add(Flight38);
            db.Flight.Add(Flight39);
            db.Flight.Add(Flight40);
            db.Flight.Add(Flight41);
            db.Flight.Add(Flight42);
            db.Flight.Add(Flight43);
            db.Flight.Add(Flight44);
            db.Flight.Add(Flight45);
            db.Flight.Add(Flight46);
            db.Flight.Add(Flight47);
            db.Flight.Add(Flight48);
            db.Flight.Add(Flight49);
            db.Flight.Add(Flight50);
            db.Flight.Add(Flight51);
            db.Flight.Add(Flight52);
            db.Flight.Add(Flight53);
            db.Flight.Add(Flight54);
            db.Flight.Add(Flight55);
            db.Flight.Add(Flight56);
            db.Flight.Add(Flight57);
            db.Flight.Add(Flight58);
            db.Flight.Add(Flight59);
            db.Flight.Add(Flight60);
            db.Flight.Add(Flight61);
            db.Flight.Add(Flight62);
            db.Flight.Add(Flight63);
            db.Flight.Add(Flight64);
            db.Flight.Add(Flight65);
            db.Flight.Add(Flight66);
            db.Flight.Add(Flight67);
            db.Flight.Add(Flight68);
            db.Flight.Add(Flight69);
            db.Flight.Add(Flight70);
            db.Flight.Add(Flight71);
            db.Flight.Add(Flight72);
            db.Flight.Add(Flight73);
            db.Flight.Add(Flight74);
            db.Flight.Add(Flight75);
            db.Flight.Add(Flight76);
            db.Flight.Add(Flight77);
            db.Flight.Add(Flight78);
            db.Flight.Add(Flight79);
            db.Flight.Add(Flight80);
            db.Flight.Add(Flight81);
            db.Flight.Add(Flight82);
            db.Flight.Add(Flight83);
            db.Flight.Add(Flight84);
            db.Flight.Add(Flight85);
            db.Flight.Add(Flight86);
            db.Flight.Add(Flight87);
            db.Flight.Add(Flight88);
            db.Flight.Add(Flight89);
            db.Flight.Add(Flight90);
            db.Flight.Add(Flight91);
            db.Flight.Add(Flight92);
            db.Flight.Add(Flight93);
            db.Flight.Add(Flight94);
            db.Flight.Add(Flight95);
            db.Flight.Add(Flight96);
            db.Flight.Add(Flight97);
            db.Flight.Add(Flight98);
            db.Flight.Add(Flight99);
            db.Flight.Add(Flight100);
            db.Flight.Add(Flight101);
            db.Flight.Add(Flight102);
            db.Flight.Add(Flight103);
            db.Flight.Add(Flight104);
            db.Flight.Add(Flight105);
            db.Flight.Add(Flight106);
            db.Flight.Add(Flight107);
            db.Flight.Add(Flight108);
            db.Flight.Add(Flight109);
            db.Flight.Add(Flight110);
            db.Flight.Add(Flight111);
            db.Flight.Add(Flight112);
            db.Flight.Add(Flight113);
            db.Flight.Add(Flight114);
            db.Flight.Add(Flight115);
            db.Flight.Add(Flight116);
            db.Flight.Add(Flight117);
            db.Flight.Add(Flight118);
            db.Flight.Add(Flight119);
            db.Flight.Add(Flight120);
            db.Flight.Add(Flight121);
            db.Flight.Add(Flight122);
            db.Flight.Add(Flight123);
            db.Flight.Add(Flight124);
            db.Flight.Add(Flight125);
            db.Flight.Add(Flight126);
            db.Flight.Add(Flight127);
            db.Flight.Add(Flight128);
            db.Flight.Add(Flight129);
            db.Flight.Add(Flight130);
            db.Flight.Add(Flight131);
            db.Flight.Add(Flight132);
            db.Flight.Add(Flight133);
            db.Flight.Add(Flight134);
            db.Flight.Add(Flight135);
            db.Flight.Add(Flight136);
            db.Flight.Add(Flight137);
            db.Flight.Add(Flight138);
            db.Flight.Add(Flight139);
            db.Flight.Add(Flight140);
            db.Flight.Add(Flight141);
            db.Flight.Add(Flight142);
            db.Flight.Add(Flight143);
            db.Flight.Add(Flight144);
            db.Flight.Add(Flight145);
            db.Flight.Add(Flight146);
            db.Flight.Add(Flight147);
            db.Flight.Add(Flight148);
            db.Flight.Add(Flight149);
            db.Flight.Add(Flight150);
            db.Flight.Add(Flight151);
            db.Flight.Add(Flight152);
            db.Flight.Add(Flight153);
            db.Flight.Add(Flight154);
            db.Flight.Add(Flight155);
            db.Flight.Add(Flight156);
            db.Flight.Add(Flight157);
            db.Flight.Add(Flight158);
            db.Flight.Add(Flight159);
            db.Flight.Add(Flight160);
            db.Flight.Add(Flight161);
            db.Flight.Add(Flight162);
            db.Flight.Add(Flight163);
            db.Flight.Add(Flight164);
            db.Flight.Add(Flight165);
            db.Flight.Add(Flight166);
            db.Flight.Add(Flight167);
            db.Flight.Add(Flight168);
            db.Flight.Add(Flight169);
            db.Flight.Add(Flight170);
            db.Flight.Add(Flight171);
            db.Flight.Add(Flight172);
            db.Flight.Add(Flight173);
            db.Flight.Add(Flight174);
            db.Flight.Add(Flight175);
            db.Flight.Add(Flight176);
            db.Flight.Add(Flight177);
            db.Flight.Add(Flight178);
            db.Flight.Add(Flight179);
            db.Flight.Add(Flight180);
            db.Flight.Add(Flight181);
            db.Flight.Add(Flight182);
            db.Flight.Add(Flight183);
            db.Flight.Add(Flight184);
            db.Flight.Add(Flight185);
            db.Flight.Add(Flight186);
            db.Flight.Add(Flight187);
            db.Flight.Add(Flight188);
            db.Flight.Add(Flight189);
            db.Flight.Add(Flight190);
            db.Flight.Add(Flight191);
            db.Flight.Add(Flight192);
            db.Flight.Add(Flight193);
            db.Flight.Add(Flight194);
            db.Flight.Add(Flight195);
            db.Flight.Add(Flight196);
            db.Flight.Add(Flight197);
            db.Flight.Add(Flight198);
            db.Flight.Add(Flight199);
            db.Flight.Add(Flight200);
            db.Flight.Add(Flight201);
            db.Flight.Add(Flight202);
            db.Flight.Add(Flight203);
            db.Flight.Add(Flight204);
            db.Flight.Add(Flight205);
            db.Flight.Add(Flight206);
            db.Flight.Add(Flight207);
            db.Flight.Add(Flight208);
            db.Flight.Add(Flight209);
            db.Flight.Add(Flight210);
            db.Flight.Add(Flight211);
            db.Flight.Add(Flight212);
            db.Flight.Add(Flight213);
            db.Flight.Add(Flight214);
            db.Flight.Add(Flight215);
            db.Flight.Add(Flight216);
            db.Flight.Add(Flight217);
            db.Flight.Add(Flight218);
            db.Flight.Add(Flight219);
            db.Flight.Add(Flight220);
            db.Flight.Add(Flight221);
            db.Flight.Add(Flight222);
            db.Flight.Add(Flight223);
            db.Flight.Add(Flight224);
            db.Flight.Add(Flight225);
            db.Flight.Add(Flight226);
            db.Flight.Add(Flight227);
            db.Flight.Add(Flight228);
            db.Flight.Add(Flight229);
            db.Flight.Add(Flight230);
            db.Flight.Add(Flight231);
            db.Flight.Add(Flight232);
            db.Flight.Add(Flight233);
            db.Flight.Add(Flight234);
            db.Flight.Add(Flight235);
            db.Flight.Add(Flight236);
            db.Flight.Add(Flight237);
            db.Flight.Add(Flight238);
            db.Flight.Add(Flight239);
            db.Flight.Add(Flight240);
            db.Flight.Add(Flight241);
            db.Flight.Add(Flight242);
            db.Flight.Add(Flight243);
            db.Flight.Add(Flight244);
            db.Flight.Add(Flight245);
            db.Flight.Add(Flight246);
            db.Flight.Add(Flight247);
            db.Flight.Add(Flight248);
            db.Flight.Add(Flight249);
            db.Flight.Add(Flight250);
            db.Flight.Add(Flight251);
            db.Flight.Add(Flight252);
            db.Flight.Add(Flight253);
            db.Flight.Add(Flight254);
            db.Flight.Add(Flight255);
            db.Flight.Add(Flight256);
            db.Flight.Add(Flight257);
            db.Flight.Add(Flight258);
            db.Flight.Add(Flight259);
            db.Flight.Add(Flight260);
            db.Flight.Add(Flight261);
            db.Flight.Add(Flight262);
            db.Flight.Add(Flight263);
            db.Flight.Add(Flight264);
            db.Flight.Add(Flight265);
            db.Flight.Add(Flight266);
            db.Flight.Add(Flight267);
            db.Flight.Add(Flight268);
            db.Flight.Add(Flight269);
            db.Flight.Add(Flight270);
            db.Flight.Add(Flight271);
            db.Flight.Add(Flight272);
            db.Flight.Add(Flight273);
            db.Flight.Add(Flight274);
            db.Flight.Add(Flight275);
            db.Flight.Add(Flight276);
            db.Flight.Add(Flight277);
            db.Flight.Add(Flight278);
            db.Flight.Add(Flight279);
            db.Flight.Add(Flight280);
            db.Flight.Add(Flight281);
            db.Flight.Add(Flight282);
            db.Flight.Add(Flight283);
            db.Flight.Add(Flight284);
            db.Flight.Add(Flight285);
            db.Flight.Add(Flight286);
            db.Flight.Add(Flight287);
            db.Flight.Add(Flight288);
            db.Flight.Add(Flight289);
            db.Flight.Add(Flight290);
            db.Flight.Add(Flight291);
            db.Flight.Add(Flight292);
            db.Flight.Add(Flight293);
            db.Flight.Add(Flight294);
            db.Flight.Add(Flight295);
            db.Flight.Add(Flight296);
            db.Flight.Add(Flight297);
            db.Flight.Add(Flight298);
            db.Flight.Add(Flight299);
            db.Flight.Add(Flight300);
            db.Flight.Add(Flight301);
            db.Flight.Add(Flight302);
            db.Flight.Add(Flight303);
            db.Flight.Add(Flight304);
            db.Flight.Add(Flight305);
            db.Flight.Add(Flight306);
            db.Flight.Add(Flight307);
            db.Flight.Add(Flight308);
            db.Flight.Add(Flight309);
            db.Flight.Add(Flight310);
            db.Flight.Add(Flight311);
            db.Flight.Add(Flight312);
            db.Flight.Add(Flight313);
            db.Flight.Add(Flight314);
            db.Flight.Add(Flight315);
            db.Flight.Add(Flight316);
            db.Flight.Add(Flight317);
            db.Flight.Add(Flight318);
            db.Flight.Add(Flight319);
            db.Flight.Add(Flight320);
            db.Flight.Add(Flight321);
            db.Flight.Add(Flight322);
            db.Flight.Add(Flight323);
            db.Flight.Add(Flight324);
            db.Flight.Add(Flight325);
            db.Flight.Add(Flight326);
            db.Flight.Add(Flight327);
            db.Flight.Add(Flight328);
            db.Flight.Add(Flight329);
            db.Flight.Add(Flight330);
            db.Flight.Add(Flight331);
            db.Flight.Add(Flight332);
            db.Flight.Add(Flight333);
            db.Flight.Add(Flight334);
            db.Flight.Add(Flight335);
            db.Flight.Add(Flight336);
            db.Flight.Add(Flight337);
            db.Flight.Add(Flight338);
            db.Flight.Add(Flight339);
            db.Flight.Add(Flight340);
            db.Flight.Add(Flight341);
            db.Flight.Add(Flight342);
            db.Flight.Add(Flight343);
            db.Flight.Add(Flight344);
            db.Flight.Add(Flight345);
            db.Flight.Add(Flight346);
            db.Flight.Add(Flight347);
            db.Flight.Add(Flight348);
            db.Flight.Add(Flight349);
            db.Flight.Add(Flight350);
            db.Flight.Add(Flight351);
            db.Flight.Add(Flight352);
            db.Flight.Add(Flight353);
            db.Flight.Add(Flight354);
            db.Flight.Add(Flight355);
            db.Flight.Add(Flight356);
            db.Flight.Add(Flight357);
            db.Flight.Add(Flight358);
            db.Flight.Add(Flight359);
            db.Flight.Add(Flight360);
            db.Flight.Add(Flight361);
            db.Flight.Add(Flight362);
            db.Flight.Add(Flight363);
            db.Flight.Add(Flight364);
            db.Flight.Add(Flight365);
            db.Flight.Add(Flight366);
            db.Flight.Add(Flight367);
            db.Flight.Add(Flight368);
            db.Flight.Add(Flight369);
            db.Flight.Add(Flight370);
            db.Flight.Add(Flight371);
            db.Flight.Add(Flight372);
            db.Flight.Add(Flight373);
            db.Flight.Add(Flight374);
            db.Flight.Add(Flight375);
            db.Flight.Add(Flight376);
            db.Flight.Add(Flight377);
            db.Flight.Add(Flight378);
            db.Flight.Add(Flight379);
            db.Flight.Add(Flight380);
            db.Flight.Add(Flight381);
            db.Flight.Add(Flight382);
            db.Flight.Add(Flight383);
            db.Flight.Add(Flight384);
            db.Flight.Add(Flight385);
            db.Flight.Add(Flight386);
            db.Flight.Add(Flight387);
            db.Flight.Add(Flight388);
            db.Flight.Add(Flight389);
            db.Flight.Add(Flight390);
            db.Flight.Add(Flight391);
            db.Flight.Add(Flight392);
            db.Flight.Add(Flight393);
            db.Flight.Add(Flight394);
            db.Flight.Add(Flight395);
            db.Flight.Add(Flight396);
            db.Flight.Add(Flight397);
            db.Flight.Add(Flight398);
            db.Flight.Add(Flight399);
            db.Flight.Add(Flight400);
            db.Flight.Add(Flight401);
            db.Flight.Add(Flight402);
            db.Flight.Add(Flight403);
            db.Flight.Add(Flight404);
            db.Flight.Add(Flight405);
            db.Flight.Add(Flight406);
            db.Flight.Add(Flight407);
            db.Flight.Add(Flight408);
            db.Flight.Add(Flight409);
            db.Flight.Add(Flight410);
            db.Flight.Add(Flight411);
            db.Flight.Add(Flight412);
            db.Flight.Add(Flight413);
            db.Flight.Add(Flight414);
            db.Flight.Add(Flight415);
            db.Flight.Add(Flight416);
            db.Flight.Add(Flight417);
            db.Flight.Add(Flight418);
            db.Flight.Add(Flight419);
            db.Flight.Add(Flight420);
            db.Flight.Add(Flight421);
            db.Flight.Add(Flight422);
            db.Flight.Add(Flight423);
            db.Flight.Add(Flight424);
            db.Flight.Add(Flight425);
            db.Flight.Add(Flight426);
            db.Flight.Add(Flight427);
            db.Flight.Add(Flight428);
            db.Flight.Add(Flight429);
            db.Flight.Add(Flight430);
            db.Flight.Add(Flight431);
            db.Flight.Add(Flight432);
            db.Flight.Add(Flight433);
            db.Flight.Add(Flight434);
            db.Flight.Add(Flight435);
            db.Flight.Add(Flight436);
            db.Flight.Add(Flight437);
            db.Flight.Add(Flight438);
            db.Flight.Add(Flight439);
            db.Flight.Add(Flight440);
            db.Flight.Add(Flight441);
            db.Flight.Add(Flight442);
            db.Flight.Add(Flight443);
            db.Flight.Add(Flight444);
            db.Flight.Add(Flight445);
            db.Flight.Add(Flight446);
            db.Flight.Add(Flight447);
            db.Flight.Add(Flight448);
            db.Flight.Add(Flight449);
            db.Flight.Add(Flight450);
            db.Flight.Add(Flight451);
            db.Flight.Add(Flight452);
            db.Flight.Add(Flight453);
            db.Flight.Add(Flight454);
            db.Flight.Add(Flight455);
            db.Flight.Add(Flight456);
            db.Flight.Add(Flight457);
            db.Flight.Add(Flight458);
            db.Flight.Add(Flight459);
            db.Flight.Add(Flight460);
            db.Flight.Add(Flight461);
            db.Flight.Add(Flight462);
            db.Flight.Add(Flight463);
            db.Flight.Add(Flight464);
            db.Flight.Add(Flight465);
            db.Flight.Add(Flight466);
            db.Flight.Add(Flight467);
            db.Flight.Add(Flight468);
            db.Flight.Add(Flight469);
            db.Flight.Add(Flight470);
            db.Flight.Add(Flight471);
            db.Flight.Add(Flight472);
            db.Flight.Add(Flight473);
            db.Flight.Add(Flight474);
            db.Flight.Add(Flight475);
            db.Flight.Add(Flight476);
            db.Flight.Add(Flight477);
            db.Flight.Add(Flight478);
            db.Flight.Add(Flight479);
            db.Flight.Add(Flight480);
            db.Flight.Add(Flight481);
            db.Flight.Add(Flight482);
            db.Flight.Add(Flight483);
            db.Flight.Add(Flight484);
            db.Flight.Add(Flight485);
            db.Flight.Add(Flight486);
            db.Flight.Add(Flight487);
            db.Flight.Add(Flight488);
            db.Flight.Add(Flight489);
            db.Flight.Add(Flight490);
            db.Flight.Add(Flight491);
            db.Flight.Add(Flight492);
            db.Flight.Add(Flight493);
            db.Flight.Add(Flight494);
            db.Flight.Add(Flight495);
            db.Flight.Add(Flight496);
            db.Flight.Add(Flight497);
            db.Flight.Add(Flight498);
            db.Flight.Add(Flight499);
            db.Flight.Add(Flight500);
            db.Flight.Add(Flight501);
            db.Flight.Add(Flight502);
            db.Flight.Add(Flight503);
            db.Flight.Add(Flight504);
            db.Flight.Add(Flight505);
            db.Flight.Add(Flight506);
            db.Flight.Add(Flight507);
            db.Flight.Add(Flight508);
            db.Flight.Add(Flight509);
            db.Flight.Add(Flight510);
            db.Flight.Add(Flight511);
            db.Flight.Add(Flight512);
            db.Flight.Add(Flight513);
            db.Flight.Add(Flight514);
            db.Flight.Add(Flight515);
            db.Flight.Add(Flight516);
            db.Flight.Add(Flight517);
            db.Flight.Add(Flight518);
            db.Flight.Add(Flight519);
            db.Flight.Add(Flight520);


            db.SaveChanges();
            

            return View();
        }

        //Finner og lister treff etter søk presentert i partial view.
        [HttpPost]
        public ActionResult ChooseFlight(ViewModel searchFlight)
        {
            if (ModelState.IsValid)
            {
                var db = new DBWebApp();
                TempData["booking"] = searchFlight.booking;
                ViewModel search = new ViewModel();
                search.flight = new ViewFlight();
                search.travelflights = db.searchTravelFlights(searchFlight);
                TempData["tids"] = db.filterIDs(search.travelflights);
                if (searchFlight.booking.roundTrip)
                {
                    search.returnflights = db.searchReturnFlight(searchFlight);
                    TempData["rids"] = db.filterIDs(search.returnflights);
                }
                return PartialView("FlightPartial",search);
            }
            return RedirectToAction("Error");
        }

        //Oppdaterer pris i partial view dynamisk
        public int UpdateDynamicPrice(int trav, int ret, int num)
        {
            int price = 0;
            var db = new DBWebApp();
            price = db.getPrice(db.getFlights(((List<List<int>>)TempData["tids"])[trav])) * num;
            TempData.Keep("tids");
            if(ret != -1)
            {
                price += db.getPrice(db.getFlights(((List<List<int>>)TempData["rids"])[ret])) * num;
                TempData.Keep("rids");
            }
            return price;
        }

        //Finner mulige flyplasser i Airport-databasen.
        [HttpPost]
        public JsonResult FindAirport(String Prefix)
        {
            var db = new WebAppContext();
            var FoundAirport = (from f in db.Airport where f.Name.StartsWith(Prefix) select new { f.Name });
            return Json(FoundAirport, JsonRequestBehavior.AllowGet);
        }

        //Hjelper til med å sette opp registrerings-viewet
        public void Helper(int travelID, int returnID)
        {
            var db = new DBWebApp();
            ViewModel reg = new ViewModel();
            reg.flight = new ViewFlight();
            reg.booking = (ViewBooking)TempData["booking"];
            reg.flight.travelIDs = (List<List<int>>)TempData["tids"];
            reg.booking.chosenTravel = db.getFlights(reg.flight.travelIDs[travelID]);
            reg.booking.totalPrice = db.getPrice(reg.booking.chosenTravel) * reg.booking.travelers;
            if (returnID != -1)
            {
                reg.flight.returnIDs = (List<List<int>>)TempData["rids"];
                reg.booking.chosenReturn = db.getFlights(reg.flight.returnIDs.ElementAt(returnID));
                reg.booking.totalPrice += db.getPrice(reg.booking.chosenReturn) * reg.booking.travelers;
            }
            TempData["help"] = reg;
        }

        //View med registrering
        public ActionResult Registration()
        {
            var finalReg = (ViewModel)TempData["help"];
            TempData["newbooking"] = finalReg.booking;
            TempData.Keep("help");
            return View(finalReg);
        }

        //Sender informasjonen videre til bekreftelses-view
        [HttpPost]
        public ActionResult Registration(ViewModel finalBooking)
        {
            finalBooking.booking = (ViewBooking)TempData["newbooking"];
            TempData["reg"] = finalBooking;
            return RedirectToAction("Confirmation");
        }

        //View med all informasjon og modal til betalings-informasjon
        public ActionResult Confirmation()
        {
            var finalView = (ViewModel)TempData["reg"];
            TempData["toDataBase"] = finalView;
            return View(finalView);
        }
 
        //Legger alt inn i database
        [HttpPost]
        public ActionResult pushDatabase(ViewModel incard)
        {
            var toPush = (ViewModel)TempData["toDataBase"];
            toPush.cardInfo = incard.cardInfo;
            if (ModelState.IsValid)
            {
                var db = new DBWebApp();
                bool pushOK = db.pushToDataBase(toPush);
                if (pushOK)
                {
                    return RedirectToAction("FinishedBooking");
                }
            }
            return RedirectToAction("Error");
        }
        
        //Viser view som bekrefter bestillingen
        public ActionResult FinishedBooking()
        {
            return View();
        }

        //View som viser når noe går galt
        public ActionResult Error()
        {
            return View();
        }

    }


    
}