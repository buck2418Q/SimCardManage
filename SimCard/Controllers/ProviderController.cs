using DTOLayer.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repos.Repository.IRepository;

namespace SimCard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderController : ControllerBase
    {
        private readonly IProviderRepository _repository;

        public ProviderController(IProviderRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public IQueryable Get()
        {
            return _repository.findAll();
        }
        [HttpPost]
        public IActionResult Add([FromBody]ProviderViewModel provider)
        {
            var p = provider.Name;

            if(provider.Name != "" ) 
            {
                if(p == null)
                {
                    return BadRequest("null here");
                }
                if (_repository.exists(p)) return BadRequest("User alredy exist");
                _repository.create(provider);
                _repository.save();
            }
            return BadRequest("Enter details");
        }
    }
}
