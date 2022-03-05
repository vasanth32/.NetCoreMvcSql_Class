using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Session1.Interface;
using Session1.Models;
using System.Diagnostics;

namespace Session1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        //Create a reference variable of IStudentRepository
         
        private readonly IStudentRepository _repository = null;

         
        public HomeController(ILogger<HomeController> logger , IStudentRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public JsonResult GetStudentDetails(int Id)
        {
            //            clsStudent repository = new clsStudent();
            //            Student studentDetails = repository.GetStudentById(Id)
            //;
            //            return Json(studentDetails);
            Student studentDetails = _repository.GetStudentById(Id);
            return Json(studentDetails);


        }

    }
}
