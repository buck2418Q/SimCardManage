using DTOLayer.ViewModel;
using SimCardData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos.Repository.IRepository
{
    public interface IProviderRepository
    {
        IQueryable<ProviderModel> findAll();
        void save();
        void remove(int id);
        void update(ProviderModel provider);
        void create(ProviderViewModel provider);
        bool exist(int id);
        bool exists(string provider);



    }
}
