﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.ViewModel
{
    public class ProviderViewModel
    {
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
