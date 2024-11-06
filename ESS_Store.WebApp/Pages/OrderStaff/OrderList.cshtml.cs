using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SWD392_Assignment.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ESS_Store.WebApp.Pages.OrderStaff
{
    public class OrderListModel : PageModel
    {
        private readonly SWD392_Assignment.Data.Models.SWD392_Group2_ESStoreContext _context;

        public OrderListModel(SWD392_Assignment.Data.Models.SWD392_Group2_ESStoreContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; } = default!;

        public string UserNameSort { get; set; }

        public string UserPhoneSort {  get; set; }

        public string UserEmailSort { get; set; }


        public async  Task OnGetAsync()
        {
            if(_context.Orders != null)
            {
              Order = await _context.Orders.Include(u => u.User)
                    .Include(o => o.OrderItems)
                    
                
                    .ToListAsync();
            }
        }
    }
}
