using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SWD392_Assignment.Data.Models;

namespace ESS_Store.WebApp.Pages.Staff
{
    public class IndexModel : PageModel
    {
        private readonly SWD392_Assignment.Data.Models.SWD392_Group2_ESStoreContext _context;

        public IndexModel(SWD392_Assignment.Data.Models.SWD392_Group2_ESStoreContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Products != null)
            {
                Product = await _context.Products
                .Include(p => p.Brand)
                .Include(p => p.Category).ToListAsync();
            }
        }
    }
}
