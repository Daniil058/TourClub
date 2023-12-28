using System;
using EquipmentStorage.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EquipmentStorage.Data.Services
{
	public class CategoryEquipmentService
	{
        private EquipmentStorageContext _context;
        public CategoryEquipmentService(EquipmentStorageContext context)
        {
            _context = context;
        }

        public async Task<List<CategoryEquipment>> GetCategoryEquipments()
        {
            var result = await _context.CategoryEquipment.Include(c=>c.Equipments).ToListAsync();
            return await Task.FromResult(result);
        }

        public async Task<List<CategoryEquipmentDTO>> GetCategoriesEquipment()
        {
            var result = await _context.CategoryEquipment.ToListAsync();

            List<CategoryEquipmentDTO> categoryEquipmentDTOs = new List<CategoryEquipmentDTO>();
            result.ForEach(r => categoryEquipmentDTOs.Add(new CategoryEquipmentDTO
            {
                Id = r.Id,
                Category = r.Category,
                Orientation = r.Orientation,
                Type = r.Type
            }));
            return await Task.FromResult(categoryEquipmentDTOs);
        }

        public async Task<CategoryEquipment> AddCategoryEquipments(CategoryEquipment categoryEquipment)
        {
            CategoryEquipment ncategoryEquipment = new CategoryEquipment
            {
                Orientation = categoryEquipment.Orientation,
                Category = categoryEquipment.Category,
                Type = categoryEquipment.Type,
            };
            var result = _context.CategoryEquipment.Add(ncategoryEquipment);
            await _context.SaveChangesAsync();
            return await Task.FromResult(result.Entity);
        }

        
    }
}

