using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_CRUD_PROJECT.Data;
using MVC_CRUD_PROJECT.Models;
using System;

namespace MVC_CRUD_PROJECT.Controllers
{
    public class StudentsController : Controller
    {
        private readonly AppDbContext _context;
        public StudentsController(AppDbContext context) 
        { 
            _context = context; 
        }

        public IActionResult Index()
        {
           return  View(_context.Students.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student s)
        {
            if (ModelState.IsValid) 
            { _context.Add(s); 
                 _context.SaveChanges(); 
                return RedirectToAction(nameof(Index));
            }
                return View(s);
        }

    }
}
