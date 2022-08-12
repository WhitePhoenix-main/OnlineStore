using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PizzaStore;

namespace PizzaStore.Pages.Products
{
    public class ProductEditModel : PageModel
    {
        private readonly PizzaStore.PizzaStoreContext _context;

        public ProductEditModel(PizzaStore.PizzaStoreContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ProductRecord ProductRecord { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.Product == null)
            {
                return NotFound();
            }

            var productrecord =  await _context.Product.FirstOrDefaultAsync(m => m.Id == id);
            if (productrecord == null)
            {
                return NotFound();
            }
            ProductRecord = productrecord;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ProductRecord).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductRecordExists(ProductRecord.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ProductRecordExists(string id)
        {
          return (_context.Product?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
