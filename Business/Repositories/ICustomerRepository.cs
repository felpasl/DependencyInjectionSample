using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model;

namespace Business.Repositories
{
    public interface ICustomerRepository
    {
        Customer Get(int id);
    }
}