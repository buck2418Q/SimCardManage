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
    
    public class DeviceRepository:IDeviceRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public DeviceRepository(AppDbContext dbContext,IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        void IDeviceRepository.create(DeviceViewModel device)
        {
            DeviceModel devices = _mapper.Map<DeviceViewModel,DeviceModel>(device);
            _dbContext.deviceModels.Add(devices);
        }

        bool IDeviceRepository.exist(int id)
        {
            return _dbContext.deviceModels.Any(device => device.Id == id);
        }

        bool IDeviceRepository.exists(string device)
        {
            return _dbContext.deviceModels.Any(devices => devices.Name == device);
            
        }

        IQueryable<DeviceModel> IDeviceRepository.findAll()
        {
            return _dbContext.Set<DeviceModel>().AsNoTracking();
        }

        void IDeviceRepository.remove(int id)
        {
            var device = _dbContext.deviceModels.Find(id);
            if (device != null)
            {
                _dbContext.deviceModels.Remove(device);

            }
            
        }

        void IDeviceRepository.save()
        {
            _dbContext.SaveChanges();
        }

        void IDeviceRepository.update(DeviceViewModel device)
        {
            _dbContext.deviceModels.Update(_mapper.Map<DeviceViewModel,DeviceModel>(device));
        }
    }
}
