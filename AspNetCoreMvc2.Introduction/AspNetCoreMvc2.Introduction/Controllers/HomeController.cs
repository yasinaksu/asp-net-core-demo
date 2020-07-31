using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreMvc2.Introduction.Entities;
using AspNetCoreMvc2.Introduction.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvc2.Introduction.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello from first application.";
        }
        public ViewResult Index2()
        {
            return View();
        }
        public ViewResult Index3()
        {
            var employees = new List<Employee>()
            {
                new Employee{CityId=1, FirstName = "Yasin", Id=1, LastName = "Aksu"},
                new Employee{CityId=2, FirstName = "Emine", Id=2, LastName = "Aksu"},
                new Employee{CityId=2, FirstName = "Emre", Id=3, LastName = "Aksu"}
            };
            var cities = new List<string>()
            {
                "Ankara", "İstanbul", "İzmir", "Adana"
            };
            var model = new EmployeeListViewModel
            {
                Employees = employees
            };
            return View(model);
        }
    }
}
