using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PoorMansRedditAPI.Models;

namespace PoorMansRedditAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly RedditDAL _reddit = new RedditDAL();

        public HomeController() { }

        public async Task<ActionResult> Index()
        {
            var reddit = await _reddit.GetImageBySearchTerm();
            return View(reddit);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
       


    }
}
