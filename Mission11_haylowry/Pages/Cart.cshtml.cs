using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mission11_haylowry.Infrastructure;
using Mission11_haylowry.Models;

namespace Mission11_haylowry.Pages
{
    public class CartModel : PageModel
    {
        //Build Instance of Database
        private IBookstoreRepository repo { get; set; }
        public Cart cart { get; set; }
        public string ReturnUrl { get; set; }
        public CartModel (IBookstoreRepository temp, Cart c)
        {
            repo = temp;
            cart = c;
        }
        
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl;
        }

        public IActionResult OnPost(int bookId, string returnUrl)
        {
            Book b = repo.Books.FirstOrDefault(x => x.BookId == bookId);

            cart.AddItem(b, 1);

            return RedirectToPage(new { ReturnUrl = returnUrl });
        }
        public IActionResult OnPostRemove(int bookId,string returnUrl)
        {
            cart.RemoveItem(cart.Items.First(x => x.Book.BookId == bookId).Book);

            return RedirectToPage(new { ReturnUrl = returnUrl });
        }
    }
} 
