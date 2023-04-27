using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Repositories;
using Model;

namespace Infraestructure.Service
{
    public class CustomerApiRepository : ICustomerRepository
    {
        public Customer Get(int id)
        {
        return new Customer() { Id = 1, Name = "Api Customer" };
        }
    }
}