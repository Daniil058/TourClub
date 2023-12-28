using System;
using EquipmentStorage.Data.Models;
using EquipmentStorage.Data.Services;
using Microsoft.AspNetCore.Mvc;

using EquipmentStorage.Data.DTOs;
namespace EquipmentStorage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDescriptionController : ControllerBase
    {
        private readonly UserDescriptionService _context;

        public UserDescriptionController(UserDescriptionService context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDescription>>> GetUserDescriptions()
        {
            return await _context.GetUserDescriptions();
        }
        
        [HttpPost("/logging")]
        public async Task<ActionResult<UserDescription>>? GetUserDescriptionsAuth(UserAuthLogPasDTO userAuthLogPasDTO)
        {
            return await _context.GetUserDescriptionsAuth(userAuthLogPasDTO);
        }
        
        [HttpPost]
        public async Task<ActionResult<UserDescription>> PostUserDescription([FromBody] UserDescriptionDTO userDescriptionDTO)
        {
            var result = await _context.AddUserDescription(userDescriptionDTO);
            if (result == null)
            {
                BadRequest();
            }

            return Ok(result);
        }

        [HttpPost("registration")]
        public async Task<ActionResult<bool>> AddUserDataReg([FromBody] UserDescrDataReg userDescrDataReg)
        {
            var result = await _context.AddUserDataReg(userDescrDataReg);
            if (result is null)
            {
                return false;
            }

            return true;
        }

    }
}

