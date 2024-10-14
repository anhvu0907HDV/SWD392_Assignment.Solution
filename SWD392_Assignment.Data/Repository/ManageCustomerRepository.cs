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
    public class ManageCustomerRepository : IManageCustomerRepository
    {
        private readonly SWD392_Group2_ESStoreContext _ESStoreContext;
        public ManageCustomerRepository(SWD392_Group2_ESStoreContext eSStoreContext)
        {
            _ESStoreContext = eSStoreContext;
        }

        public async Task<Status> CreateCustomer(User model)
        {
            var status = new Status();
            var user = _ESStoreContext.Users.FirstOrDefault(x => x.Email != null && x.Email.Equals(model.Email));
            if (user != null)
            {
                status.Message="User Existed!";
                status.StatusCode = 0;
            }
            else
            {
                _ESStoreContext.Users.Add(model);
                _ESStoreContext.SaveChanges();
                status.Message = "Create Customer Seuccessfully!";
                status.StatusCode = 1;
            }
            return status;
        }
    }
}
