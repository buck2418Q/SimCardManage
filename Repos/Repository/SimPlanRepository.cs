using AutoMapper;
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
    public class SimPlanRepository:ISimCardPlanRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        public SimPlanRepository(AppDbContext dbContext, IMapper mapper)

        {

            _dbContext = dbContext;
            _mapper = mapper;

        }

        void ISimCardPlanRepository.create(SimCardPlanViewModel plan)
        {
            _dbContext.simCardPlanModels.Add(plan);
        }

        bool ISimCardPlanRepository.exist(int id)
        {
            throw new NotImplementedException();
        }

        bool ISimCardPlanRepository.exists(string plan)
        {
            throw new NotImplementedException();
        }

        IQueryable<SimCardPlanModel> ISimCardPlanRepository.findAll()
        {
            throw new NotImplementedException();
        }

        void ISimCardPlanRepository.remove(int id)
        {
            throw new NotImplementedException();
        }

        void ISimCardPlanRepository.save()
        {
            throw new NotImplementedException();
        }

        void ISimCardPlanRepository.update(SimCardPlanViewModel plan)
        {
            throw new NotImplementedException();
        }
    }
}
