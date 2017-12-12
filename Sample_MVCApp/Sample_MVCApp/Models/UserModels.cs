using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Sample_MVCApp.Models
{
    public class UserModels
    {
        [DisplayName("First Name")]
        [Required (ErrorMessage="First name is required")]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Address { get; set; }
        [Required]
        [StringLength (50)]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        [Range(100,1000000)]
        public decimal Salary { get; set; }
    }
}