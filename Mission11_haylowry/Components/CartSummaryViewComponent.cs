using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mission11_haylowry.Models;

namespace Mission11_haylowry.Components
{
    public class CartSummaryViewComponent : ViewComponent 
    {
        private Cart cart { get; set; }
        public CartSummaryViewComponent (Cart cartService)
        {
            cart = cartService;
        }
        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
