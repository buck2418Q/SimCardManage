using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCardData.Models
{
    public class SimCardPlanModel
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string? Description { get; set; }
        public int Data { get; set; }
        public int Duration { get; set; }
    }
}
