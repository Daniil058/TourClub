using System;
using EquipmentStorage.Data.DTOs;
using EquipmentStorage.Data.Models;
using EquipmentStorage.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace EquipmentStorage.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EquipmentController : ControllerBase
    {
        private readonly EquipmentService _context;

        public EquipmentController(EquipmentService context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EquipmentDTO>>> GetEquipments()
        {
            return await _context.GetEquipments();
        }

        [HttpGet("condition/{id}")]
        public async Task<ActionResult<IEnumerable<EquipmentDTO>>> GetEquipmentsWithConditionId(int id)
        {
            return await _context.GetEquipmentsWithConditionId(id);
        }

        [HttpGet("category/{id}")]
        public async Task<ActionResult<IEnumerable<EquipmentDTO>>> GetEquipmentsWithCategoryId(int id)
        {
            return await _context.GetEquipmentsWithCategoryId(id);
        }

        [HttpGet("category/orientation/{name}")]
        public async Task<ActionResult<IEnumerable<EquipmentDTO>>> GetEquipmentsWithOrientationName(string name)
        {
            return await _context.GetEquipmentsWithOrientationName(name);
        }

        [HttpGet("category/category/{name}")]
        public async Task<ActionResult<IEnumerable<EquipmentDTO>>> GetEquipmentsWithCategoryName(string name)
        {
            return await _context.GetEquipmentsWithCategoryName(name);
        }

        [HttpGet("{name}")]
        public async Task<ActionResult<IEnumerable<EquipmentDTO>>> GetEquipmentsByName(string name)
        {
            return await _context.GetEquipmentsByName(name);
        }

        [HttpGet("one/{id}")]
        public async Task<ActionResult<EquipmentMoreDTO>> GetEquipment(int id)
        {
            return await _context.GetEquipment(id);
        }

        /*
                [HttpGet("/incomplete")]
                public async Task<ActionResult<IEnumerable<IncompleteEquipmentDTO>>> GetIncompleteEquipmentDTOs()
                {
                    return await _context.GetIncompleteEquipmentDTOs();
                }
        */
        [HttpPost]
        public async Task<ActionResult<Equipment>> PostEquipment([FromBody] EquipmentAddDTO equipment)
        {
            var result = await _context.AddEquipment(equipment);
            if (result == null)
            {
                BadRequest();
            }

            return Ok(result);
        }

    }
}

