using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repos.Repository.IRepository;
using SimCardData.Models;

namespace SimCard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceController : ControllerBase
    {
        private readonly IDeviceRepository _deviceRepository;
        private readonly IMapper _mapper;

        public DeviceController(IDeviceRepository deviceRepository, IMapper mapper)
        {
            _deviceRepository = deviceRepository;
            _mapper = mapper;
        }
        [HttpPost]
        public IActionResult Create([FromBody] DeviceViewModel device)
        {
            
            _deviceRepository.create(device);
            _deviceRepository.save();
            return Ok(device);
        }
        [HttpGet]
        public IQueryable Get()
        {
            return _deviceRepository.findAll();
        }

       
    }
}
