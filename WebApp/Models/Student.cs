using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Display(Name = "Student FirstName")]
        [Required(ErrorMessage = "Student  FirstName can't Empty !")]
        public string FirstName { get; set; }
        [Display(Name = "Student LastName")]
        [Required(ErrorMessage = "Student LastName can't Empty !")]
        public string LastName { get; set; }
        [Display(Name = "Student Email Address")]
        [Required(ErrorMessage = "Student Email can't Empty !")]
        [EmailAddress(ErrorMessage = "Email Address is not valid !")]
        public string Email { get; set; }
        [Display(Name = "Student Mobile")]
        [Required(ErrorMessage = "Student Mobile can't Empty !")]
        [RegularExpression(@"^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$",
            ErrorMessage = "Invalid Mobile number !")]
        public string Mobile { get; set; }
        [Display(Name = "Student Gender")]
        [Required(ErrorMessage = "Student Gender can't Empty !")]
        public string Gender { get; set; }
    }
}
