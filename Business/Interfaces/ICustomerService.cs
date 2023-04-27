using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model;

namespace Business.Interfaces
{
    public interface ICustomerService
    {
        Customer Get(int id);
    }
}