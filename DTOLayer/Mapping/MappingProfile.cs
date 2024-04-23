using AutoMapper;
using DTOLayer.ViewModel;
using SimCardData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<UserViewModel, UserModel>().ReverseMap();
            CreateMap<AdminViewModel, AdminModel>().ReverseMap();
            CreateMap<DeviceViewModel, DeviceModel>().ReverseMap();
            CreateMap<ProviderViewModel, ProviderModel>().ReverseMap();
            CreateMap<UserViewModel, UserModel>().ReverseMap();
            CreateMap<SimCardPlanViewModel, SimCardPlanModel>().ReverseMap();

        }
    }
}
