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

        public async Task<bool> create(ProviderModel provider)
        {
            var result = await _dbContext.providerModels.AddAsync(provider);
            return result.State == EntityState.Added;
        }

        public  IQueryable<ProviderModel> findAll()
        {
            return  _dbContext.Set<ProviderModel>().AsNoTracking();
        }

        public async Task<ProviderModel> GetUnique(int id)
        {
            return await _dbContext.providerModels.FirstOrDefaultAsync(s => s.Id == id)??new ProviderModel();
        }

        public async Task<bool> GetUnique(string name)
        {
            return await _dbContext.providerModels.FirstOrDefaultAsync(s => s.Name == name)!=null?true:false;
        }

        
        public async Task save()
        {
            await _dbContext.SaveChangesAsync();
        }

       bool IProviderRepository.remove(ProviderModel provider)
        {
             var result = _dbContext.providerModels.Remove(provider);
            return result.State == EntityState.Deleted;
        }
    }
}
