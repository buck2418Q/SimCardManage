using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repos.Repository.IRepository;
using SimCardData.Models;

namespace SimCard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminRepository _repository;

        public AdminController(IAdminRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public IQueryable get()
        {
            return _repository.findAll();
        }
        [HttpPost]
        public IActionResult create([FromBody]AdminViewModel admin)
        {
            _repository.create(admin);
            return  _repository.save() == 1 ? Ok("Admin Added") : NotFound("Error occured");
        }
    }
}
