using SWD392_Assignment.Data.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD392_Assignment.Data.Repository.IRepository
{
    public interface IManageRole
    {
        Task<IEnumerable<Role>> ListRole();
    }
}
