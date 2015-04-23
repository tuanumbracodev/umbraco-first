using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CreateForm.Models
{
    public class ContactModel
    {
        [Display(Name = "Your name:")]
        [Required(ErrorMessage = "Please, enter some value into your name!")]
        public string Name { get; set; }

        [Display(Name = "Your email:")]
        [Required(ErrorMessage = "Please, enter some value into your email!")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please, the format of the e-mail address is incorrect!")]
        public string EmailAddress { get; set; }

        [Display(Name = "Your subject")]
        [Required(ErrorMessage = "Please, enter some value into your subject!")]
        public string Subject { get; set; }

        [Display(Name = "Your message")]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
    }
}