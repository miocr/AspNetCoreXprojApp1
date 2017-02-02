using System;
using System.Collections.Generic;

namespace MvcApp.Models
{
	public class Person
	{
		public int PersonId { get; set; }
  		public string Name { get; set; }

		//public string SurName { get; set; }

  		public int Age { get; set; }

		public List<Computer> Computers {get; set;}
	}

}
