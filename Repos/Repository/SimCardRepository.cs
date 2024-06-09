using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Repos.Repository.IRepository;
using SimCardData.Data;
using SimCardData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos.Repository
{
   
    public class SimCardRepository : ISimRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public SimCardRepository(AppDbContext dbContext,IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;

        }
        void ISimRepository.create(SimViewModel sim)
        {

            SimModel sims = new SimModel();
            sims.Number = sim.Number;
            sims.UserId = sim.UserId;
            var device = _dbContext.deviceModels.Find(sim.DeviceId);
            if (device != null)
            {
                sims.deviceModel = device;

            }
            sims.ProviderId = sim.ProviderId;
            var provider = _dbContext.providerModels.Find(sim.ProviderId);
            if (provider != null)
            {
                sims.ProviderModel = provider;

            }
            sims.IsActiveUser = sim.IsActiveUser;

            
            var user = _dbContext.userModels.Find(sim.UserId);
            if (user != null)
            {
                sims.userModel = user;

            }
            
            var plan = _dbContext.simCardPlanModels.Find(sim.SimCardPlanModelId);
            if (plan != null)
            {
                sims.SimCardPlanModel = plan;

            }





            _dbContext.simModels.Add(sims);

        }

        bool ISimRepository.exist(int id)
        {
            throw new NotImplementedException();
        }

        bool ISimRepository.exists(string sim)
        {
            throw new NotImplementedException();
        }

        IQueryable<SimModel> ISimRepository.findAll()
        {
           return  _dbContext.simModels.Include(s => s.userModel).AsNoTracking();
           
        }

        void ISimRepository.remove(int id)
        {
            throw new NotImplementedException();
        }

        int ISimRepository.save()
        {
            return _dbContext.SaveChanges();
        }

        void ISimRepository.update(SimModel sim)
        {
            throw new NotImplementedException();
        }
    }
}
