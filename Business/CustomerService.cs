using Business.Interfaces;
using Business.Repositories;
using Model;

namespace Business;
public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository customerRepository;

    public CustomerService(ICustomerRepository customerRepository)
    {
        this.customerRepository = customerRepository;
    }

    public Customer Get(int id){
        // Outras Logicas
        return customerRepository.Get(id);        
    }

}
