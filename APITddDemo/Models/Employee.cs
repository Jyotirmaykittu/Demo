using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APITddDemo.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }

        [Required(ErrorMessage = "Your Name is required")]
        [StringLength(40, MinimumLength = 4, ErrorMessage = "{0} should be between 4 to 40 Char")]
        public string Name { get; set; }
        public string experience { get; set; }
        public string Technology { get; set; }

        [ForeignKey("project")]
        public int ProjId { get; set; }
    }
}
