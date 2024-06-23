using AutoMapper;
using Azure;
using DTOLayer.ViewModel;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Repos.Repository.IRepository;
using SimCardData.Models;

namespace SimCard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderController(IProviderRepository repository, IMapper mapper) : ControllerBase
    {
        [HttpGet]
        public IQueryable Get() => repository.findAll();

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] ProviderViewModel provider)
        {
            var p = provider.Name;

            if (p == "") return BadRequest("Enter details");
            if (p == null)
            {
                return BadRequest("null here");
            }
            if (await repository.GetUnique(p)) return BadRequest("User already exist");
            await repository.create(mapper.Map<ProviderModel>(provider));
            await repository.save();
            return BadRequest("Enter details");
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<ProviderViewModel>> Update(int id, [FromBody] ProviderViewModel viewModel)
        {
            var entity = await repository.GetUnique(id);
            mapper.Map(viewModel, entity);
            await repository.save();
            return Ok(await repository.GetUnique(id));
        }

        [HttpPatch("id:int")]
        public async Task<ActionResult<ProviderViewModel>> Patch(int id,[FromBody] JsonPatchDocument<ProviderViewModel> viewModel)
        {
            ProviderModel model = await repository.GetUnique(id);
            viewModel.ApplyTo(mapper.Map<ProviderViewModel>(model));
            return mapper.Map<ProviderViewModel>(model);

        }

    }
}
