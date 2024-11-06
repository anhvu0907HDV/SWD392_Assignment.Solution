using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SWD392_Assignment.Data.Models;

namespace ESS_Store.WebApp.Pages.OrderStaff
{
    public class UpdateOrderModel : PageModel
    {
        private readonly SWD392_Group2_ESStoreContext _context;

        public UpdateOrderModel(SWD392_Group2_ESStoreContext context)
        {
            _context = context;

        }

        [BindProperty]
        public Staff Staff { get; set; }

        [BindProperty]
        public User User { get; set; }

        [BindProperty]

        public Order Order { get; set; }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if(id == null || _context.Orders == null)
            {
                return NotFound();
            }
            var order = await _context.Orders.FirstOrDefaultAsync(o => o.Id == id);
            if(order == null)
            {
                return NotFound();
            }
            Order = order;
            ViewData["StaffId"] = new SelectList(_context.Staffs, "Id", "Name");
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Name", "Address");
            return Page(); 
        }

        public async Task<IActionResult> OnPostAsync()
        {
            _context.Attach(Order).State = EntityState.Modified;    

            try
            {
                await _context.SaveChangesAsync(); 

            }catch(DbUpdateConcurrencyException)
            {
                if(!OrderExist(Order.Id))
                {
                    return NotFound();
                }else
                {
                    throw;
                }
            }
            return RedirectToPage("./OrderList");

        } 

        private bool OrderExist(int id)
        {
            return (_context.Orders?.Any(o => o.Id == id)).GetValueOrDefault();

        }


    }
}
