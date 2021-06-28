using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSchool.Model
{
    public class Course : EntityBase
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(150)]
        public string Category { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [Range(1, 50, ErrorMessage = "Valid range between 1 and 50")]
        public int Duration { get; set; }

    }
}
