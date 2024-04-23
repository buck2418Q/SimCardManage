using DTOLayer.ViewModel;
using SimCardData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos.Repository.IRepository
{
    public interface IDeviceRepository
    {
        IQueryable<DeviceModel> findAll();
        void save();
        void remove(int id);
        void update(DeviceViewModel device);
        void create(DeviceViewModel device);
        bool exist(int id);
        bool exists(string device);
    }
}
