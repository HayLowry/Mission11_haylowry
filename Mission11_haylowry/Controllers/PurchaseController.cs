﻿using Microsoft.AspNetCore.Mvc;
using Mission11_haylowry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission11_haylowry.Controllers
{
    public class PurchaseController : Controller
    {
        private IPurchaseRepository repo { get; set; }
        private Cart cart { get; set; }
        public PurchaseController(IPurchaseRepository temp, Cart c)
        {
            repo = temp;
            cart = c;
        }
        [HttpGet]
        public IActionResult Checkout()
        {
            return View(new Purchase());
        }
        [HttpPost]
        public IActionResult Checkout(Purchase purchase)
        {
            if (cart.Items.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry your cart is empty!");
            }

            if (ModelState.IsValid)
            {
                purchase.Lines = cart.Items.ToArray();
                repo.SavePurchase(purchase);
                cart.ClearBasket();

                return RedirectToPage("/ConfirmPurchase");
            }
            else
            {
                return View();
            }
        }
    }
}
