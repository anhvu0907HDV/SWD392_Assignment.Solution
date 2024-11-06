using SWD392_Assignment.Data.Models;
using SWD392_Assignment.Data.Models.DTO;
using SWD392_Assignment.Data.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD392_Assignment.Data.Repository
{
   public class ManageOrder : IManageOrderRepository        
    {
        private readonly SWD392_Group2_ESStoreContext _ESStoreContext;

        public ManageOrder(SWD392_Group2_ESStoreContext context)
        {
            _ESStoreContext = context;
        }

        public async Task<Status> CreateOrder(Order model)
        {
            try
            {

                var status = new Status();
                var order =  _ESStoreContext.Orders.FirstOrDefault();
                _ESStoreContext.Orders.Add(order);
                _ESStoreContext.SaveChanges();
                status.Message = "Create Order Successfully";
                status.StatusCode = 1;
                return status;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
