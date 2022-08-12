using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PizzaStore;

namespace PizzaStore.Pages.Products
{
    public class ProductCreateModel : PageModel
    {
        private readonly PizzaStore.PizzaStoreContext _context;

        public ProductCreateModel(PizzaStore.PizzaStoreContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ProductRecord ProductRecord { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Product == null || ProductRecord == null)
            {
                return Page();
            }

            _context.Product.Add(ProductRecord);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
