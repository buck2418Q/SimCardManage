using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SimCardData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCardData.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<AdminModel> adminModels { get; set; }
        public DbSet<DeviceModel> deviceModels  { get; set; }
        public DbSet<ProviderModel> providerModels  { get; set; }
        public DbSet<SimCardPlanModel> simCardPlanModels  { get; set; }
        public DbSet<SimModel> simModels  { get; set; }
        public DbSet<UserModel> userModels  { get; set; }

    }
}
