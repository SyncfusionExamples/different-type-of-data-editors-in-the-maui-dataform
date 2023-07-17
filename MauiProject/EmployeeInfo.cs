using Syncfusion.Maui.DataForm;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiProject
{
    public class EmployeeInfo 
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "First Name should not be empty")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [StringLength(10, ErrorMessage = "Contact number should not exceed 10 digits")]
        [Display(Name = "Contact Number")]
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        public string Country { get; set; }
        [Display(Name = "Date Joined")]
        public DateTime? DateJoined { get; set; }
        public bool Confirmed { get; set; }

    }
}
