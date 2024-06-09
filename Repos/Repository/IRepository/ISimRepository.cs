using DTOLayer.ViewModel;
using SimCardData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos.Repository.IRepository
{
    public interface ISimRepository
    {
        IQueryable<SimModel> findAll();
        int save();
        void remove(int id);
        void update(SimModel sim);
        void create(SimViewModel sim);
        bool exist(int id);
        bool exists(string sim);
    }
}
