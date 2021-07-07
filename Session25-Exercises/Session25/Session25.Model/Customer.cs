using System;
using System.ComponentModel.DataAnnotations;

namespace Session25.Model {
    public class Customer {

        public Guid Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "First Name")]
        [StringLength(50, ErrorMessage = "First name cannot exceed 50 characters in length.")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Last Name")]
        [StringLength(150, ErrorMessage = "Last name cannot exceed 150 characters in length.")]
        public string Surname { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "AFM")]
        [RegularExpression(@"\d{9}", ErrorMessage = "AFM name must be 9 digits long.")]
        public string AFM { get; set; }

        [Display(Name = "Active")]
        public bool Active { get; set; }

    }
}
