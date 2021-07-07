using Session25.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session25.Services {
    public class MemoryCustomerStorage : ICustomerStorage {


        private List<Customer> innerList { get; set; }


        public MemoryCustomerStorage() {

            innerList = new List<Customer>();

        }


        public void AddCustomer(Customer customer) {

            if (customer.Id == Guid.Empty) {

                customer.Id = Guid.NewGuid();
                innerList.Add(customer);
                return;
            }

            var selectedCustomer = GetCustomerById(customer.Id);

            selectedCustomer.Name = customer.Name;

            selectedCustomer.Surname = customer.Surname;

            selectedCustomer.AFM = customer.AFM;

            selectedCustomer.Active = customer.Active;

        }

        public List<Customer> GetAllCustomers() {

            return innerList;

        }

        public Customer GetCustomerById(Guid id) {

            return innerList.FirstOrDefault(customer => customer.Id == id);

        }

        public void RemoveCustomer(Guid id) {

            var selectedCustomer = GetCustomerById(id);
            if (selectedCustomer == null)
                throw new Exception(string.Format("Customer with id '{0}' was not found.", id));

            innerList.Remove(selectedCustomer);


        }
    }
}
