using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManushiApi.Entities;
using ManushiApi.Interfaces;

namespace ManushiApi.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepo _customerRepo;

        public CustomerService(ICustomerRepo customerRepo)
        {
            _customerRepo = customerRepo;
        }

        public List<Customer> GetAllCustomers() => _customerRepo.GetAllCustomers();

        public Customer GetCustomerById(int id) => _customerRepo.GetCustomerById(id);
    }
}
