using DTOLayer.ViewModel;
using SimCardData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos.Repository.IRepository
{
    public interface IAdminRepository
    {
        IQueryable<AdminModel> findAll();
        int save();
        void remove(int id);
        void update(AdminViewModel admin);
        void create(AdminViewModel admin);
        bool exist(int id);
        bool exists(string admin);
    }
}
