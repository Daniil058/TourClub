using System;
using EquipmentStorage.Data.Models;
using EquipmentStorage.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace EquipmentStorage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterestController : ControllerBase
    {
        private readonly InterestService _context;

        public InterestController(InterestService context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Interest>>> GetInterests()
        {
            return await _context.GetInterests();
        }

        [HttpPost]
        public async Task<ActionResult<Interest>> PostInterest([FromBody] Interest interest)
        {
            var result = await _context.AddInterest(interest);
            if (result == null)
            {
                BadRequest();
            }

            return Ok(result);
        }

    }
}

