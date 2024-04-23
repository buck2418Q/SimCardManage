using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCardData.Models
{
    public class DeviceViewModel
    {
       
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; }
       
        


    }
}
