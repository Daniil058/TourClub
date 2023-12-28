using System;
using EquipmentStorage.Data.Models;
using EquipmentStorage.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace EquipmentStorage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryEquipmentController : ControllerBase
    {
        private readonly CategoryEquipmentService _context;

        public CategoryEquipmentController(CategoryEquipmentService context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryEquipment>>> GetCategoryEquipments()
        {
            return await _context.GetCategoryEquipments();

        }

        [HttpGet("dto")]
        public async Task<ActionResult<IEnumerable<CategoryEquipmentDTO>>> GetCategoriesEquipment()
        {
            return await _context.GetCategoriesEquipment();
        }

        [HttpPost]
        public async Task<ActionResult<CategoryEquipment>> PostCategoryEquipment([FromBody] CategoryEquipment categoryEquipment)
        {
            var result = await _context.AddCategoryEquipments(categoryEquipment);
            if (result == null)
            {
                BadRequest();
            }

            return Ok(result);
        }

    }
}

