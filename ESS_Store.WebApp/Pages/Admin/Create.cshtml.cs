using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SWD392_Assignment.Data.Models;
using SWD392_Assignment.Data.Repository.IRepository;

namespace ESS_Store.WebApp.Pages.Admin
{
    public class CreateModel : PageModel
    {
        private readonly IManageCustomerRepository _customerRepository;
        private readonly IManageRole _roleRepository;
        public CreateModel(IManageCustomerRepository customerRepository, IManageRole roleRepository)
        {
            _customerRepository = customerRepository;
            _roleRepository = roleRepository;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var roles = await _roleRepository.ListRole();
            ViewData["RoleId"] = new SelectList(roles, "Id", "RoleName");
            return Page();
        }

        [BindProperty]
        public User User { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

          var Status = await _customerRepository.CreateCustomer(User);
          if (Status.StatusCode == 0) {
                var roles = await _roleRepository.ListRole();
                ViewData["RoleId"] = new SelectList(roles, "Id", "RoleName");
                return Page();
            }
            return RedirectToPage("./Index");
        }
    }
}
