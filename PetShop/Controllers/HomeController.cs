using Microsoft.AspNetCore.Mvc;
using PetShop.Models;
using PetShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Pet> pets = new List<Pet>
            {
                new Pet {Id = 1, Name = "Zeus", Breed = "PitBull" },
                new Pet {Id = 2, Name = "Zeus", Breed = "PitBull" }
            };

            var homeViewModel = new HomeViewModel
            {
                NomeUsuario = "Hugo",
                Pet = pets,
                SaldoUsuario = 100.0m
            };

            return View(homeViewModel);
        }
        public IActionResult Inicio()
        {
            return View();
        }
    }
}
