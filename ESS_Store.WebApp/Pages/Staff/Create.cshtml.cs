using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SWD392_Assignment.Data.Models;

namespace ESS_Store.WebApp.Pages.Staff
{
    public class CreateModel : PageModel
    {
        private readonly SWD392_Assignment.Data.Models.SWD392_Group2_ESStoreContext _context;

        public CreateModel(SWD392_Assignment.Data.Models.SWD392_Group2_ESStoreContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["BrandId"] = new SelectList(_context.Brands, "Id", "Id");
        ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Products == null || Product == null)
            {
                return Page();
            }

            _context.Products.Add(Product);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
