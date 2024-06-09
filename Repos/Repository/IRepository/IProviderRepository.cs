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
        Task save();
        bool remove(ProviderModel provider);
        Task<bool> create(ProviderModel provider);
        Task<ProviderModel> GetUnique(int id);
        Task<bool> GetUnique(string name);



    }
}
