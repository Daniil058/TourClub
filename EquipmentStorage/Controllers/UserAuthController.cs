using System;
using Microsoft.AspNetCore.Mvc;
using EquipmentStorage.Data.DTOs;

using Microsoft.EntityFrameworkCore;
using EquipmentStorage.Data.Services;
using EquipmentStorage.Data.Models;

namespace EquipmentStorage.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAuthController : ControllerBase
    {
        private readonly UserAuthService _context;

        public UserAuthController(UserAuthService context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserAuth>>> GetUsersAuth()
        {
            return await _context.GetUsersAuth();
        }

        /*
        [HttpGet("/incomplete")]
        public async Task<ActionResult<IEnumerable<IncompleteUserAuthDTO>>> GetUsersAuthIncomplete()
        {
            return await _context.GetUsersAuthIncomplete();
        }
    */
        [HttpGet("/userauth/{id}")]
        public async Task<ActionResult<ContactInformation>> GetContactInformation(int id)
        {
            return await _context.GetContactInformation(id);
        }

        [HttpPost]
        public async Task<ActionResult<UserAuth>> PostuserAuth([FromBody] UserAuthDTO userAuthDTO)
        {
            var result = await _context.AddUserAuth(userAuthDTO);
            if (result == null)
            {
                BadRequest();
            }

            return Ok(result);
        }

        [HttpPost("registration")]
        public async Task<int?> AddDataRegistration([FromBody] UserAuthDataReg data)
        {
            var result = await _context.AddDataRegistration(data);
            if (result is null)
                return -1;
            return result.Id;
        }

    }
}

