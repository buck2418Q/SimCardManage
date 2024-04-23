
using System.ComponentModel.DataAnnotations.Schema;


namespace SimCardData.Models
{
    public class SimModel
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int UserId { get; set; }

        [ForeignKey("deviceModelsId")]
        public DeviceModel deviceModel { get; set; } = null!;


        public int ProviderId { get; set; }
        [ForeignKey("providerModelsId")]
        public ProviderModel ProviderModel { get; set; } = null!;
        public bool IsActiveUser { get; set; } = true;
       
        [ForeignKey("userModelsId")]
        public UserModel userModel { get; set; } = null!;

        [ForeignKey("simCardPlanModelsId")]
        public SimCardPlanModel SimCardPlanModel { get; set; } = null!;
    }
}
