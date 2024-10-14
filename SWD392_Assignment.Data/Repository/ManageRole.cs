using Microsoft.EntityFrameworkCore;
using SWD392_Assignment.Data.Models;
using SWD392_Assignment.Data.Repository.IRepository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD392_Assignment.Data.Repository
{
    public class ManageRole : IManageRole
    {
        private readonly SWD392_Group2_ESStoreContext _ESStoreContext;
        public ManageRole(SWD392_Group2_ESStoreContext eSStoreContext)
        {
            _ESStoreContext = eSStoreContext;
        }
        public async Task<IEnumerable<Role>> ListRole()
        {
            return await _ESStoreContext.Roles.ToListAsync();
        }
    }
}
