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
    public class AdminRepository : IAdminRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public AdminRepository(AppDbContext dbContext,IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        void IAdminRepository.create(AdminViewModel admin)
        {
            AdminModel admins =  _mapper.Map<AdminViewModel,AdminModel>(admin);
            _dbContext.adminModels.Add(admins);
            
        }

        bool IAdminRepository.exist(int id)
        {
            return _dbContext.adminModels.Any(admin => admin.Id == id);
        }

        bool IAdminRepository.exists(string admin)
        {
            return _dbContext.adminModels.Any(admins => admins.Username == admin);
        }

        IQueryable<AdminModel> IAdminRepository.findAll()
        {
            return _dbContext.Set<AdminModel>().AsNoTracking();
        }

        void IAdminRepository.remove(int id)
        {
            var k = _dbContext.adminModels.Find(id);
            if (k != null)
            {
                _dbContext.adminModels.Remove(k);

            }
        }

        void IAdminRepository.save()
        {
            _dbContext.SaveChanges();
        }

        void IAdminRepository.update(AdminViewModel admin)
        {
            
            _dbContext.adminModels.Update(_mapper.Map<AdminViewModel, AdminModel>(admin));
        }
    }
}
