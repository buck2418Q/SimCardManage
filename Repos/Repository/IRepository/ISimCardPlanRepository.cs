using DTOLayer.ViewModel;
using SimCardData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos.Repository.IRepository
{
    public interface ISimCardPlanRepository
    {
        IQueryable<SimCardPlanModel> findAll();
        void save();
        void remove(int id);
        void update(SimCardPlanViewModel plan);
        void create(SimCardPlanViewModel plan);
        bool exist(int id);
        bool exists(string plan);
    }
}
