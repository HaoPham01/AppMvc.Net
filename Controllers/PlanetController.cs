using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using App.Services;

namespace App.Controllers
{   
    
    public class PlanetController : Controller
    {
        private readonly PlanetService _planetService;

        public PlanetController(PlanetService planetService){
            _planetService = planetService;
        }

        [Route("/danh-sach-cac-hanh-tinh.html")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("hanhtinh/{id:int}")]
        public IActionResult PlanetInfo(int id){
             var planet = _planetService.Where(p => p.Id == id).FirstOrDefault();
             return View("Detail", planet);
        }

        [BindProperty(SupportsGet = true, Name = "action")]

        public string Name { get; set; }

        public IActionResult Mercury()
        {
            var planet = _planetService.Where(p => p.Name == Name).FirstOrDefault();
            return View("Detail", planet);
        }

        public IActionResult Venus()
        {
            var planet = _planetService.Where(p => p.Name == Name).FirstOrDefault();
            return View("Detail", planet);
        }

        public IActionResult Earth()
        {
            var planet = _planetService.Where(p => p.Name == Name).FirstOrDefault();
            return View("Detail", planet);
        }

        public IActionResult Mars()
        {
            var planet = _planetService.Where(p => p.Name == Name).FirstOrDefault();
            return View("Detail", planet);
        }

        public IActionResult Jupiter()
        {
            var planet = _planetService.Where(p => p.Name == Name).FirstOrDefault();
            return View("Detail", planet);
        }

        public IActionResult Uranus()
        {
            var planet = _planetService.Where(p => p.Name == Name).FirstOrDefault();
            return View("Detail", planet);
        }

        public IActionResult Neptune()
        {
            var planet = _planetService.Where(p => p.Name == Name).FirstOrDefault();
            return View("Detail", planet);
        }

        public IActionResult Saturn()
        {
            var planet = _planetService.Where(p => p.Name == Name).FirstOrDefault();
            return View("Detail", planet);
        }
        
    }
}