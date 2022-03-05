using Microsoft.AspNetCore.Mvc;
using Session1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session1.Controllers
{
    [Route("StudentRouting")]  //Controller level routing
    public class studentController : Controller
    {
        public IActionResult Index()
        {
            
            Student student = new Student()
            {
                StudentId = 2,
                Name = "James2",
                Branch = "CSE2",
                Section = "A2",
                Gender = "Male2"
            };
            //storing Student Data

            //View Data
            //ViewData["Student"] = student;
            //ViewData["Title"] = "Student Details Page";
            //ViewData["Header"] = "Student Details";

            ViewBag.Title = "Student Details Page";
            ViewBag.Header = "Student Details";
            //ViewBag.Student = student;

            //normal view
            //return View();

            //strongly typed view
            return View(student);
        }


        [Route("myDetails")]    //Attribute level
        //View Model 
        public ViewResult Details()
        {
            //Student Basic Details
            Student student = new Student()
            {
                StudentId = 101,
                Name = "Dillip",
                Branch = "CSE",
                Section = "A",
                Gender = "Male"
            };

            //Student Address
            Address address = new Address()
            {
                StudentId = 101,
                City = "Mumbai",
                State = "Maharashtra",
                Country = "India",
                Pin = "400097"
            };

            //Creating the View model
            StudentDetailsViewModel studentDetailsViewModel = new StudentDetailsViewModel()
            {
                Student = student,
                Address = address,
                Title = "Student Details Page",
                Header = "Student Details",
            };


            
            //Pass the studentDetailsViewModel to the view
            return View(studentDetailsViewModel);
        }

    }
}
