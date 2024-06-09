using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repos.Repository;
using Repos.Repository.IRepository;
using SimCardData.Models;

namespace SimCard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanController : ControllerBase
    {
        private readonly IPlanRepository _repository;
       
        public PlanController(IPlanRepository repository)
        {
            _repository = repository;
           
        }

        [HttpGet]

        public IQueryable Get()
        {
            return _repository.findAll();


        }
        [HttpPost]
        public IActionResult Create([FromBody]SimCardPlanViewModel plan)
        {
            _repository.create(plan);
            return _repository.save() == 1 ? Ok("Created plan") : NotFound("There is some issue");
        }

    }
}
