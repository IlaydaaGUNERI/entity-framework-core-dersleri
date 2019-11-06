﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class CourseController : Controller
    {
        private IRepository repository;
        public CourseController(IRepository _repository)
        {
            repository = _repository;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}