using SimCardData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos.Repository.IRepository
{
    public interface IPlanRepository
    {
        IQueryable<SimCardPlanModel> findAll();
        int save();
        void create(SimCardPlanViewModel plan);

        //implenet them later
        //void remove(int id);
        //void update(SimCardPlanViewModel plan);

        //bool exist(int id);
        //bool exists(string plan);
    }
}
