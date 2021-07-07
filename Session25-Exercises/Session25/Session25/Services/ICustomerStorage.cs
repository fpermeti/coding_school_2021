using Session25.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session25.Services {
    public interface ICustomerStorage {

        public void AddCustomer(Customer customer);
        public void RemoveCustomer(Guid id);
        public List<Customer> GetAllCustomers();
        public Customer GetCustomerById(Guid id);

    }
}
