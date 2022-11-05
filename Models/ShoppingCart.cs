using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COSE71197_DL.Models
{
    public class ShoppingCart
    {
        private readonly AppDbContext _appDbContext;
        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public ShoppingCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session; // call service "?" means don't access session if null

            var context = services.GetService<AppDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString(); // ?? ternary operatator with if null check
            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        public void AddToCart(Hardware hardware, int amount)
        {
            var shoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(s => s.Hardware.HardwareId == hardware.HardwareId && s.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Hardware = hardware,
                    Amount = amount
                };

                _appDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++; //adding the same item to the shopping cart
            }

            _appDbContext.SaveChanges(); //at the end save the changes 
        }

        public int RemoveFromCart(Hardware hardware) //int as this is the amount in the cart 
        {
            var shoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(s => s.Hardware.HardwareId == hardware.HardwareId && s.ShoppingCartId == ShoppingCartId); // same logic as AddToCart() above


            var localAmount = 0; //the counter 

            if (shoppingCartItem != null) //check if empty
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _appDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

            _appDbContext.SaveChanges();

            return localAmount;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? (ShoppingCartItems = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Include(s => s.Hardware)
                .ToList());
        }

        public void ClearCart()
        {
            var cartItems = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId);

            _appDbContext.ShoppingCartItems.RemoveRange(cartItems);
            _appDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.Hardware.Price * c.Amount).Sum(); // inclusive of VAT

            return total;
        }
    }
}
