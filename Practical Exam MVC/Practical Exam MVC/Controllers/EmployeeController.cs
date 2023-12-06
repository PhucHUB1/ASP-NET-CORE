using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Practical_Exam_MVC.Entities;
using Practical_Exam_MVC.Models;

namespace Practical_Exam_MVC.Controllers;

public class EmployeeController : Controller
{ 
       private readonly DataContext _context;

        public EmployeeController(DataContext context)
        {
            _context=context;
        }



        //GET:/<Controller>/
        public IActionResult Index()
        {
            List<Employee> ls = _context.Products.ToList();
            return View(ls);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeModel model)
        {   
            if (ModelState.IsValid)
            {
                //save to db
                _context.Products.Add(new Employee { EmployeeName=model.EmployeeName, Rank=model.Rank }) ;         
                _context.SaveChanges();
            
                // REDIRECT to list
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
