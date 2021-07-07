using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Session25.Model;
using Session25.Services;

namespace Session25.Pages.Shared
{
    public class EditModel : PageModel
    {

        [BindProperty]
        public Customer SelectedListItem { get; set; }

        private ICustomerStorage _storage;

        public EditModel(ICustomerStorage storage) {
            _storage = storage;
        }

        public void OnGet(int id) {
            if (id == 0) {
                SelectedListItem = new Customer();
                return;
            }

            SelectedListItem = _storage.GetCustomerById(id);
        }

        public IActionResult OnPost() {
            _storage.AddCustomer(SelectedListItem);

            return RedirectToPage("List");
        }

        public IActionResult OnPostCancel() {
            return RedirectToPage("List");
        }

        public IActionResult OnPostDelete() {
            _storage.RemoveCustomer(SelectedListItem.Id);
            return RedirectToPage("List");
        }

    }
}
