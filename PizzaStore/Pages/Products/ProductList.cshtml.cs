using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzaStore
{
    public class ProductListModel : PageModel
    {

        private PizzaStoreContext _context { get; init; }
        
        public ProductListModel(PizzaStoreContext context)
        {
            _context = context;
        }
        
        public List<ProductRecord> products = new();

        public void OnGet()
        {
            products = _context.Product.ToList();
        }
    }
}