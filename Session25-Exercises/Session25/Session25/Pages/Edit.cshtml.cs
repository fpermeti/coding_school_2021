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
    public class EditModel : PageModel
    {

        [BindProperty]
        public Customer SelectedCustomer { get; set; }

        private ICustomerStorage _storage;

        public EditModel(ICustomerStorage storage) {
            _storage = storage;
        }

        public void OnGet(Guid id) {
            if (id == Guid.Empty) {
                SelectedCustomer = new Customer();
                return;
            }

            SelectedCustomer = _storage.GetCustomerById(id);
        }

        public IActionResult OnPost() {

            if (ModelState.IsValid) {

                SelectedCustomer.Name= SelectedCustomer.Name.Trim();
                SelectedCustomer.Surname= SelectedCustomer.Surname.Trim();
                SelectedCustomer.AFM= SelectedCustomer.AFM.Trim();

                _storage.AddCustomer(SelectedCustomer);

                return RedirectToPage("List");


            }

            return Page();
        }

        public IActionResult OnPostCancel() {
            return RedirectToPage("List");
        }

        public IActionResult OnPostDelete() {
            _storage.RemoveCustomer(SelectedCustomer.Id);
            return RedirectToPage("List");
        }

    }
}
