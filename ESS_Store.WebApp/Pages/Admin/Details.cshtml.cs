﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SWD392_Assignment.Data.Models;

namespace ESS_Store.WebApp.Pages.Admin
{
    public class DetailsModel : PageModel
    {
        private readonly SWD392_Assignment.Data.Models.SWD392_Group2_ESStoreContext _context;

        public DetailsModel(SWD392_Assignment.Data.Models.SWD392_Group2_ESStoreContext context)
        {
            _context = context;
        }

      public User User { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            else 
            {
                User = user;
            }
            return Page();
        }
    }
}
