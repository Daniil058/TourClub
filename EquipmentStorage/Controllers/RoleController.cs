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
    public class RoleController : ControllerBase
    {
        private readonly RoleService _context;

        public RoleController(RoleService context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Role>>> GetRoles()
        {
            return await _context.GetRoles();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Role>> GetRole(int id)
        {
            var role = await _context.GetRole(id);

            if (role == null)
            {
                return NotFound();
            }


            return role;
        }

        [HttpPost]
        public async Task<ActionResult<Role>> PostRole([FromBody] Role role)
        {
            var result = await _context.AddRole(role);
            if (result == null)
            {
                BadRequest();
            }

            return Ok(result);
        }
    }

   

}

