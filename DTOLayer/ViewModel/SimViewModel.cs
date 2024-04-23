
using System.ComponentModel.DataAnnotations.Schema;


namespace SimCardData.Models
{
    public class SimViewModel
    {
        
        public int Number { get; set; }
        public int UserId { get; set; }

       
        public int DeviceId { get; set; }


        public int ProviderId { get; set; }
       
        public bool IsActiveUser { get; set; } = true;
       
       
        public int userModelId { get; set; } 

        public int SimCardPlanModelId { get; set; }
    }
}
