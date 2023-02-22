using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission06_tsteven6.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_tsteven6.Controllers
{
    public class HomeController : Controller
    {
        
        private MovieContext mdContext { get; set; }
        public HomeController(MovieContext someName)
        {
            
            mdContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MovieDB()
        {
            ViewBag.Categories = mdContext.Category.ToList();

            return View();
        }
        [HttpPost]
        public IActionResult MovieDB(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                mdContext.Add(ar);
                mdContext.SaveChanges();
                return View("Confirmation", ar);
            }
            else
            {
                ViewBag.Categories = mdContext.Category.ToList();
                return View();
            }
            
        }

        public IActionResult MovieList ()
        {

            var applications = mdContext.Responses
                .Include(x => x.Category)
                .OrderBy(x => x.Category).ToList();

            return View(applications);
        }

        [HttpGet]
        public IActionResult Edit(int applicationid)
        {
            ViewBag.Categories = mdContext.Category.ToList();

            var application = mdContext.Responses.Single(x => x.ApplicationId == applicationid);

            return View("MovieDB", application);
        }
        [HttpPost]
        public IActionResult Edit (ApplicationResponse blah)
        {

            mdContext.Update(blah);
            mdContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
        [HttpGet]
        public IActionResult Delete(int applicationid)
        {
            var application = mdContext.Responses.Single(x => x.ApplicationId == applicationid);

            return View(application);
        }

        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            mdContext.Responses.Remove(ar);
            mdContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
     
    }
}
