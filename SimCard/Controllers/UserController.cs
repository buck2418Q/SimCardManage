using AutoMapper;
using DTOLayer.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repos.Repository.IRepository;
using SimCardData.Models;

namespace SimCard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;
        public UserController(IUserRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

            
        }
        [HttpGet]
        public IQueryable get()
        {
            return _repository.Getall();
        }
        [HttpPost]
        public IActionResult Add([FromBody]UserViewModel userEntity) {
            
            
            if (_repository.exist(userEntity)) { return BadRequest("user already exist"); }
                _repository.add(userEntity);
            _repository.save();
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult remove(int id)
        {
            bool userExist = _repository.exist(id);
            if (userExist)
            {
                _repository.remove(id);
                _repository.save();
                return Ok("user Deleted");
            }


           
            
            return NotFound("User not Found");

        }


    }
}
