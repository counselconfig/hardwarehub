using COSE71197_DL.Models;
using COSE71197_DL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COSE71197_DL.Controllers
{
    public class HardwareController : Controller
    {
        private readonly IHardwareRepository _hardwareRepository;
        private readonly ICategoryRepository _categoryRepository;

        public HardwareController(IHardwareRepository hardwareRepository, ICategoryRepository categoryRepository)
        {
            _hardwareRepository = hardwareRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string category)
        {
            IEnumerable<Hardware> hardwares;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                hardwares = _hardwareRepository.GetAllHardware.OrderBy(c => c.HardwareId);
                currentCategory = "All Hardware";
            }
            else
            {
                hardwares = _hardwareRepository.GetAllHardware.Where(c => c.Category.CategoryName == category);

                currentCategory = _categoryRepository.GetAllCategories.FirstOrDefault(currentCategory => currentCategory.CategoryName == category)?.CategoryName;
            }

            return View(new HardwareListViewModel
            {
                Hardwares = hardwares,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var hardware = _hardwareRepository.GetHardwareByID(id);
            if (hardware == null)
                return NotFound();

            return View(hardware);
        }
    }
}

