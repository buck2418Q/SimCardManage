using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCardData.Models
{
    public class AdminViewModel
    {
        
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
