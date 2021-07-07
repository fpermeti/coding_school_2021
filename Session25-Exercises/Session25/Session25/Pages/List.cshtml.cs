using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Session25.Model;
using Session25.Services;

namespace Session25.Pages
{
    public class ListModel : PageModel
    {

        public List<Customer> Customers = new List<Customer>();

        private ICustomerStorage _storage;

        public ListModel(ICustomerStorage storage) {
            _storage = storage;
        }

        public void OnGet() {
            Customers = _storage.GetAllCustomers();
        }

    }
}
