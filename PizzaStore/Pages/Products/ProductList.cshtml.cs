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
    public class ProductListModel : PageModel
    {
        private readonly PizzaStore.PizzaStoreContext _context;

        public ProductListModel(PizzaStore.PizzaStoreContext context)
        {
            _context = context;
        }

        public IList<ProductRecord> ProductRecord { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Product != null)
            {
                ProductRecord = await _context.Product.ToListAsync();
            }
        }
    }
}
