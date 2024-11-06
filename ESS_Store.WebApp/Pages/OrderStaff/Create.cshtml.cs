using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SWD392_Assignment.Data.Models;
using SWD392_Assignment.Data.Repository.IRepository;

namespace ESS_Store.WebApp.Pages.OrderStaff
{
    public class CreateModel : PageModel

    {
        private readonly SWD392_Group2_ESStoreContext _context;


        private readonly IManageOrderRepository _orderRepository;

        private readonly IManageCustomerRepository _customerRepository;
        public CreateModel(IManageOrderRepository orderRepository, IManageCustomerRepository customerRepository, SWD392_Group2_ESStoreContext context)
        {
            _context = context;
            _orderRepository = orderRepository;
            _customerRepository = customerRepository;
        }

      

        [BindProperty]

        public Order Order { get; set; } = default!;

        [BindProperty]

        public User User { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {

            try
            {

                var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == Order.UserId);

                if (user == null)
                {
                    // Nếu không tìm thấy User, trả về thông báo lỗi
                    ModelState.AddModelError(string.Empty, "User không tồn tại.");
                    return Page(); // Quay lại trang hiện tại để hiển thị thông báo lỗi
                }



                _context.Orders.Add(Order);
                await _context.SaveChangesAsync();

                //var Status = await _orderRepository.CreateOrder(Order);

                return RedirectToPage("./OrderList");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }
    }

}
