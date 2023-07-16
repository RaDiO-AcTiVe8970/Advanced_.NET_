using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab_task.Models
{
    public class Register
    {
        [Required(ErrorMessage = "Please Enter name.")]
        [StringLength(100, ErrorMessage = "Name Length should be less than 100 characters")]
        [RegularExpression(@"[A-Za-z .]+$", ErrorMessage ="Not Valid name")]
        public string name { get; set; }
        [Required(ErrorMessage = "Please enter username.")]
        [StringLength(15, ErrorMessage ="Name Length should be less than 15 characters")]
        [RegularExpression(@"^[A-Za-z0-9!@#$%^&*()_+\-=\[{\]};':""\\|,.<>\/?]+$]", ErrorMessage ="Not Valid Username")]
        public string username { get; set; }
        [Required(ErrorMessage = "Please select gender.")]
        public string gender { get; set; }
        [Required(ErrorMessage = "Please select profession.")]
        public string[] profession { get; set; }
        [Required(ErrorMessage = "Please Enter email.")]
        [Range(typeof(DateTime), "01/01/1900", "01/01/2003", ErrorMessage = "You must be at least 20 years old.")]
        public DateTime dob { get; set; }
        [Required]
        [RegularExpression(@"^\d{2}-\d{5}-[1-3]$", ErrorMessage ="Please Enter ID in valid format.")]
        public string stdid { get; set; }
        [Required(ErrorMessage ="Please Enter email.")]
        [RegularExpression(@"^\d{2}-\d{5}-[1-3]@student.aiub.edu$", ErrorMessage = "Please Enter email in valid format.")]
        public string email { get; set; }
    }
}