using MongoDB.Driver;
using System;
using System.Linq;
using System.Web.Mvc;
using MongoDB.AspNet.Models;

namespace MongoDB.AspNet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult MyView()
        {
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "csharp";

            // Get Database
            Console.WriteLine(">>> Getting Database >>>");
            MongoClient client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            Console.WriteLine("*** Database connected ***");

            var employees = database.GetCollection<Employee>("employee");
            var data = from a in employees.AsQueryable() select a;

            return View(data.ToArray<Employee>());
        }
    }
}