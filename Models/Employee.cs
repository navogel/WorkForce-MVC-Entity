using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bangazon_RedJags.Models
{
    public class Employee
    {
        
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(55, MinimumLength = 1, ErrorMessage = "First Name length should be between 1 and 55 characters")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(55, MinimumLength = 1, ErrorMessage = "Last Name length should be between 1 and 55 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Department Id is required")]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }

        public Computer Computer { get; set; }

       
        [StringLength(55, MinimumLength = 5, ErrorMessage = "eMail length should be between 5 and 55 characters")]
        public string Email { get; set; }

        
        [Display(Name = "Is supervisor")]
        public bool IsSupervisor { get; set; } = false;

        
        [Display(Name = "Computer")]
        public int ComputerId { get; set; } = -1;

        



    }
}
