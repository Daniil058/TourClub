using System;
using EquipmentStorage.Data.Models;
using EquipmentStorage.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace EquipmentStorage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConditionController : ControllerBase
    {
        private readonly ConditionService _context;

        public ConditionController(ConditionService context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Condition>>> GetConditions()
        {
            return await _context.GetConditions();
        }

        [HttpGet("dto")]
        public async Task<ActionResult<IEnumerable<ConditionDTO>>> GetConditionsDTO()
        {
            return await _context.GetConditionsDTO();
        }

        [HttpPost]
        public async Task<ActionResult<Condition>> PostCondition([FromBody] Condition condition)
        {
            var result = await _context.AddCondition(condition);
            if (result == null)
            {
                BadRequest();
            }

            return Ok(result);
        }

    }
}

