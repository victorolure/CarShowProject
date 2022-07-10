using CarShowProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CarShowProject.Controllers
{
    public class CarController : Controller
    {
        private CarShowContext _db;
        public CarController(CarShowContext context)
        {
            _db = context;
        }

        public IActionResult Index()
        {
            List<Brand> brands = _db.Brands.Include(b=> b.Vehicles).ToList();
            return View(brands );
        }
    }
}
