using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using MvcApp.Models;

namespace MvcApp.ViewComponents
{
	public class SimpleViewComponent : ViewComponent
	{
		// public IViewComponentResult Invoke()
		// {
		// 	var data = GetSampleData();
		// 	return View(data);
		// }

		public async Task<IViewComponentResult> InvokeAsync()
		{ 
			await Task.Delay(1000);
			var data = GetSampleData();
            ViewData["Message"] = "Component with page";
			return View(data);
		}

		private List<string> GetSampleData()
		{
			List<string> data = new List< string > ();
			data.Add("One");
			data.Add("Two");
			data.Add("Three");
			return data;
		}

	}
}
