using SWD392_Assignment.Data.Models;
using SWD392_Assignment.Data.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD392_Assignment.Data.Repository.IRepository
{
    public interface  IManageCustomerRepository
    {
        Task<Status> CreateCustomer(User model);
    }
}
