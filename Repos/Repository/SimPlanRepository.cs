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
    public class SimPlanRepository: IPlanRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        public SimPlanRepository(AppDbContext dbContext, IMapper mapper)

        {

            _dbContext = dbContext;
            _mapper = mapper;

        }

        void IPlanRepository.create(SimCardPlanViewModel plan)
        {
            
            _dbContext.simCardPlanModels.Add(_mapper.Map<SimCardPlanViewModel, SimCardPlanModel>(plan));

            
        }

        //bool IPlanRepository.exist(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //bool IPlanRepository.exists(string plan)
        //{
        //    throw new NotImplementedException();
        //}

        IQueryable<SimCardPlanModel> IPlanRepository.findAll()
        {
            return _dbContext.Set<SimCardPlanModel>().AsNoTracking();
        }

        //void IPlanRepository.remove(int id)
        //{
        //    throw new NotImplementedException();
        //}

        int IPlanRepository.save()
        {
            return _dbContext.SaveChanges();
        }

        //void IPlanRepository.update(SimCardPlanViewModel plan)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
