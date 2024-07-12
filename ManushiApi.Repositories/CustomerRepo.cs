using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManushiApi.Entities;
using ManushiApi.Interfaces;

namespace ManushiApi.Repositories
{
    public class CustomerRepo: ICustomerRepo
    {
        private readonly List<Customer> _customers;

        public CustomerRepo()
        {
            _customers = new List<Customer>
            {
                new Customer 
                { 
                    Id = 1, 
                    FirstName = "Manushi", 
                    LastName = "Shah" 
                },
                new Customer 
                { 
                    Id = 2, 
                    FirstName = "Prahil", 
                    LastName = "Shah" 
                },
                new Customer 
                { 
                    Id = 3, 
                    FirstName = "Raj", 
                    LastName = "Shah" 
                }
            };
        }

        public List<Customer> GetAllCustomers() => _customers;

        public Customer GetCustomerById(int id) => _customers.FirstOrDefault(c => c.Id == id);
    }

}
