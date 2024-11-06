using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SWD392_Assignment.Data.Models;

namespace ESS_Store.WebApp.Pages.Login
{
    public class LoginModel : PageModel
    {


        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string ErrorMessage { get; set; }

        // Database context (assumed you have a context set up)
        private readonly SWD392_Group2_ESStoreContext _context;

        public LoginModel(SWD392_Group2_ESStoreContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                ErrorMessage = "Both fields are required.";
                return Page();
            }

            // Querying the database for a matching username and password
            var user = await _context.Users
                                     .FirstOrDefaultAsync(u => u.Username == Username && u.Password == Password);

            if (user != null)
            {
                if (user.IsDeleted)
                {
                    ErrorMessage = "This account is no longer active.";
                    return Page();
                }

                // Login successful - redirect to home or dashboard
                return RedirectToPage("/Index");
            }
            else
            {
                ErrorMessage = "Invalid username or password.";
                return Page();
            }
        }
    }
    
}
