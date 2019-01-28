using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClothesShop.Models;
using ClothesShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClothesShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IClothRepository clothRepository;
        public HomeController(IClothRepository cloth)
        {
            clothRepository = cloth;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var clothes = clothRepository.GetCloths().OrderBy(p => p.Name);
            HomeViewModel homeViewModel = new HomeViewModel
            {
                Title = "Welcome to Omar clothes shop",
                Clothes = clothes.ToList()
            };
            return View(homeViewModel);
        }
        public IActionResult Details(int id)
        {
            var cloth = clothRepository.GetCloth(id);
            if (cloth == null)
            {
                return NotFound();
            }
            return View(cloth);
        }
    }

}
