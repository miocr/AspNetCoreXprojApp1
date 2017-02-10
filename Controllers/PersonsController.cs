using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcApp.Models;

namespace MvcApp.Controllers
{
  public class PersonsController : Controller
  {
    private AppDbContext db;

    #region DataInit
    public PersonsController(AppDbContext dbContext)
    {
      db = dbContext;
    }
    #endregion

    public IActionResult Index()
    {
      Person newPerson = new Person();
      newPerson.Name = "JA";
      newPerson.SurName = "JAJA";
      newPerson.Age = 10;
      ViewBag.AllPersons = db.Persons;

      List<Person> personList = new List<Person>();
      foreach (Person pers in db.Persons)
      {
        personList.Add(pers);
      }

      return View(db.Persons);
    }

  }


}