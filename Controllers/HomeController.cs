using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcApp.Models;

namespace MvcApp.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext db;

        public HomeController(AppDbContext dbContext)
        {
            db = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TagHelper()
        {
            ViewBag.Title = "This is TagHelper page";
            Person person1 = new Person();
            person1.Age = 18;
            person1.Name = "Karel Nowak";
            //person1.SurName = "Nowak";
            //person1.PersonId = 1;
            ViewData["Message"] = "Person model edit";
            //using (var db = new AppDbContext())
            {
                
                if (ModelState.IsValid)
                {
                    db.Persons.Add(person1);
                    //db.SaveChanges();

                    Computer computer1 = new Computer();
                    computer1.Name = "Acer ASX1";
                    computer1.Brand = "ACER";
                    computer1.Owner = person1;
                    db.Computers.Add(computer1);
                    db.SaveChanges();
                }

            }
            return View(person1);
        }

        public IActionResult Component()
        {
            //return ViewComponent("Simple");
            ViewData["Message"] = "Home controller - action Component";

            return View();
        }

        public IActionResult About()
        {

            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {

            return View();
        }
    }
}
