﻿using Session25.Model;
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

            if (customer.Id == 0) {
                customer.Id = innerList.Count + 1;
                innerList.Add(customer);
                return;
            }

            var selectedItem = GetCustomerById(customer.Id);

            selectedItem.Name = customer.Name;

            selectedItem.Surname = customer.Surname;

            selectedItem.AFM = customer.AFM;

            selectedItem.Active = customer.Active;

        }

        public List<Customer> GetAllCustomers() {

            return innerList;

        }

        public Customer GetCustomerById(int id) {

            return innerList.FirstOrDefault(customer => customer.Id == id);


        }

        public void RemoveCustomer(int id) {

            var selectedItem = GetCustomerById(id);
            if (selectedItem == null)
                throw new Exception(string.Format("Item with id '{0}' was not found.", id));

            innerList.Remove(selectedItem);


        }
    }
}