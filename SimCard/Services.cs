using DTOLayer.Mapping;
using Repos.Repository.IRepository;
using Repos.Repository;
using SimCardData.Data;

namespace SimCard
{
    public class Services
    {
        public Services(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped<IDeviceRepository, DeviceRepository>();
            services.AddScoped<IProviderRepository, ProviderRepository>();
            services.AddScoped<IPlanRepository, SimPlanRepository>();
            services.AddScoped<ISimRepository, SimCardRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddControllers().AddNewtonsoftJson();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

        }
    }
}
