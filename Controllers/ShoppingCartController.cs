using COSE71197_DL.Models;
using COSE71197_DL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COSE71197_DL.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IHardwareRepository _hardwareRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IHardwareRepository hardwareRespository, ShoppingCart shoppingCart)
        {
            _hardwareRepository = hardwareRespository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems(); //retrieves all items and set properties wit those items 

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int hardwareId)  // whole object not needed just the id if hardware exists can be added to cart
        {
            var selectedHardware = _hardwareRepository.GetAllHardware.FirstOrDefault(c => c.HardwareId == hardwareId);

            if (selectedHardware != null)
            {
                _shoppingCart.AddToCart(selectedHardware, 1); //1 integer passed in as items added 1 at a time
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int hardwareId)  // remove hardware item
        {
            var selectedHardware = _hardwareRepository.GetAllHardware.FirstOrDefault(c => c.HardwareId == hardwareId);

            if (selectedHardware != null)
            {
                _shoppingCart.RemoveFromCart(selectedHardware); //only needs the hardware to be removed not the amount so no interger passed in 
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult ClearCart()
        {
            _shoppingCart.ClearCart();
            return RedirectToAction("Index");
        }
    }
}
