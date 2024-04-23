using AutoMapper;
using DTOLayer.ViewModel;
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
    public class UserRepository : IUserRepository
    {

        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public UserRepository(AppDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }

        void IUserRepository.add(UserViewModel user)
        {
            UserModel users  =  _mapper.Map<UserViewModel,UserModel>(user);

            _context.userModels.Add(users);
        }
        bool IUserRepository.exist(UserViewModel userM)
        {
            return _context.userModels.Any(user => user.Email == userM.Email) ? true : false;

        }


        void IUserRepository.delete(UserModel user)
        {
            _context.userModels.Remove(user);
        }

         IQueryable<UserModel> IUserRepository.get(int id)
        {
            return   _context.Set<UserModel>().Where(user => user.Id == id).AsNoTracking();
        }

        IQueryable<UserModel> IUserRepository.Getall()
        {
            return _context.Set<UserModel>().AsNoTracking();
        }

        bool IUserRepository.remove(int id)
        {
            var user = _context.userModels.Find(id);
            if (user != null)
            {
                
                return _context.userModels.Remove(user) != null? true : false;

            }
            return false;

        }

        bool IUserRepository.save()
        {
            return _context.SaveChanges() == 1 ? true : false;


        }

        void IUserRepository.update(UserModel user)
        {
            _context.Update(user);
        }


        bool IUserRepository.exist(int id)
        {
            return _context.userModels.Any(user => user.Id == id) ? true : false;
        }

    }
}
