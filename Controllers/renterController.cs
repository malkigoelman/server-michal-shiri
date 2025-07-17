using smr.Core.Services;
using Microsoft.AspNetCore.Mvc;
using smr.Entitis;
using AutoMapper;
using smr.Core.DTOs;
using smr.Models;
using Microsoft.AspNetCore.Authorization;

namespace smr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class renterController : ControllerBase
    {
        private readonly IrenterService _renterService;
        private readonly IMapper _mapper;
        public renterController(IrenterService renterService, IMapper map)
        {
            _renterService = renterService;
            _mapper = map;
        }

        // GET: api/<renterController>
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult> Get()
        {
            var rentersList = await _renterService.GetListAsync();
            var renters = _mapper.Map<IEnumerable<renterDTO>>(rentersList);
            return Ok(renters);
        }
        // GET api/<renterController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var rent = await _renterService.GetByIdAsync(id);
            var renter = _mapper.Map<renterDTO>(rent);
            if (rent != null)
            {
                return Ok(renter);
            }
            return NotFound();

        }

        // POST api/<renterController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] renterPostModel r)
        {
            var newRenter = _mapper.Map<Renter>(r);
            await _renterService.AddAsync(newRenter);

            var renterDTO = _mapper.Map<renterDTO>(newRenter);
            return Ok(renterDTO);
        }

        // PUT api/<renterController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] renterPostModel r)
        {
            var NewRenter = await _renterService.UpdateAsync(id, _mapper.Map<Renter>(r));
            if (NewRenter != null)
            {
                return Ok(NewRenter);
            }
            return NotFound();
        }
        // PUT api/<bankersController>/status/5
        [HttpPut("status/{id}")]
        public async Task<ActionResult> Put(int id, bool isActive)
        {
            var renter = await _renterService.GetByIdAsync(id);
            if (renter == null)
            {
                return Conflict();
            }
            await _renterService.PutStatusAsync(id, isActive);
            return Ok();
        }

    }
}
