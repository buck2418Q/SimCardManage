using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repos.Repository.IRepository;
using SimCardData.Models;

namespace SimCard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SimController : ControllerBase
    {
        private readonly ISimRepository _repository;
        public SimController(ISimRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public ActionResult Get([FromBody]SimViewModel sim)
        {
            _repository.create(sim);
            _repository.save();
            return Ok(sim);
            
        }
        [HttpGet]
        public IQueryable GetAll() 
        {
            return _repository.findAll();
        }
    }
}
