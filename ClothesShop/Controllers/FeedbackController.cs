using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClothesShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClothesShop.Controllers
{
    [Authorize]
    public class FeedbackController : Controller
    {
        private readonly IFeedbackRepository feedbckRepository;
        public FeedbackController(IFeedbackRepository feedbck)
        {
            feedbckRepository = feedbck;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                feedbckRepository.AddFeedback(feedback);
                return RedirectToAction("FeedbackComplete");
            }
            return View(feedback);
        }
        public IActionResult FeedbackComplete()
        {
            return View();
        }
    }
}
