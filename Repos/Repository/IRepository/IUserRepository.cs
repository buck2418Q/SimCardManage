using DTOLayer.ViewModel;
using SimCardData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos.Repository.IRepository
{
    public interface IUserRepository
    {
        IQueryable<UserModel> Getall();
        void add(UserViewModel user);
        void update(UserModel user);
        void delete(UserModel user);
        bool remove(int id);
        IQueryable<UserModel> get(int id);
        bool exist(UserViewModel user);

        
        bool save();
        bool exist(int id);
  



    }
}
