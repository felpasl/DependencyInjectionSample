
using Business.Repositories;
using Model;

namespace Infraestructure.Database;
public class CustomerDatabaseRepository : ICustomerRepository
{
    public Customer Get(int id)
    {
        return new Customer() { Id = 1, Name = "Database Customer" };
    }
}
