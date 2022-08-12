using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PizzaStore;

namespace PizzaStore.Pages.Products
{
    public class ProductDetailsModel : PageModel
    {
        private readonly PizzaStore.PizzaStoreContext _context;

        public ProductDetailsModel(PizzaStore.PizzaStoreContext context)
        {
            _context = context;
        }

      public ProductRecord ProductRecord { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.Product == null)
            {
                return NotFound();
            }

            var productrecord = await _context.Product.FirstOrDefaultAsync(m => m.Id == id);
            if (productrecord == null)
            {
                return NotFound();
            }
            else 
            {
                ProductRecord = productrecord;
            }
            return Page();
        }
    }
}
