using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.ViewModel
{
    public class UserViewModel
    {
       
        [Required]
        public string FirstName { get; set; } = "";
        [Required]
        public string LastName { get; set; } = "";
        public string Email { get; set; } = "";
        public string PhoneNo { get; set; } = "";
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";

    }
}
