using AutoMapper;
using DTOLayer.ViewModel;
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
    public class ProviderRepository : IProviderRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        public ProviderRepository(AppDbContext dbContext,IMapper mapper)

        {

            _dbContext = dbContext;
            _mapper = mapper;
            
        }
        void IProviderRepository.create(ProviderViewModel provider)
        {
            ProviderModel providers = _mapper.Map<ProviderViewModel, ProviderModel>(provider);
            _dbContext.providerModels.Add(providers);
           
        }

        bool IProviderRepository.exist(int id)
        {
            return _dbContext.providerModels.Any(provider => provider.Id == id);
        }

        bool IProviderRepository.exists(string provider)
        {
            return _dbContext.providerModels.Any(pro => pro.Name == provider);

        }

        IQueryable<ProviderModel> IProviderRepository.findAll()
        {
            return _dbContext.Set<ProviderModel>().AsNoTracking();
        }

        void IProviderRepository.remove(int id)
        {
            var providerEntity = _dbContext.providerModels.Find(id);
            if (providerEntity != null)
            {
                _dbContext.providerModels.Remove(providerEntity);

            }

        }

        void IProviderRepository.save()
        {
            _dbContext.SaveChanges();
        }

        void IProviderRepository.update(ProviderModel provider)
        {
            _dbContext.providerModels.Update(provider);
        }
    }
}
