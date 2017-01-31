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
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Index3()
		{
			ViewBag.Title = "This is Index3";
			Person person1 = new Person();
            person1.Age = 18;
            person1.Name = "Karel Novák";
            person1.PersonId = 1;
			return View(person1);

		}

		public IActionResult Component()
		{
			//return ViewComponent("Simple");
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
