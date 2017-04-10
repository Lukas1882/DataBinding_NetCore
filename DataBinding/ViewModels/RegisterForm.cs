using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataBinding.ViewModels
{
    public class RegisterForm
    {
        public RegisterForm()
        {
            GenderOptions = new List<string> { "Male", "Female" };
        }

        [StringLength(160, MinimumLength = 6)]
        [DataType(DataType.EmailAddress)]
        [Required()]
        [DisplayFormat]
        public string Email { get; set; }

        [StringLength(20, MinimumLength = 3)]
        [Required()]
        public string UserName { get; set; }

        [StringLength(6, MinimumLength = 4)]
        [Required()]
        public string Gender { get; set; }

        public List<string> GenderOptions { get; set; }

        [DataType(DataType.Password)]
        [StringLength(25, MinimumLength = 6)]
        [Required()]
        public string Password { get; set; }

        [Compare("Password")]
        [DataType(DataType.Password)]
        [StringLength(25, MinimumLength = 6)]
        [Required()]
        public string ConfirmPassword { get; set; }
    }
}
