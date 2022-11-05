using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COSE71197_DL.Models;
using COSE71197_DL.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace COSE71197_DL.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHardwareRepository _hardwareRepository;

        public HomeController(IHardwareRepository hardwareRepository)
        {
            _hardwareRepository = hardwareRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                HardwareOnSale = _hardwareRepository.GetHardwareOnSale
            };

            return View(homeViewModel);
        }
    }
}