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
    public class DetailsModel : PageModel
    {
        private readonly SWD392_Assignment.Data.Models.SWD392_Group2_ESStoreContext _context;

        public DetailsModel(SWD392_Assignment.Data.Models.SWD392_Group2_ESStoreContext context)
        {
            _context = context;
        }

      public Product Product { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            else 
            {
                Product = product;
            }
            return Page();
        }
    }
}
