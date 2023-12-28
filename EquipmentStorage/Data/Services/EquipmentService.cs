using System;
using EquipmentStorage.Data.Models;
using Microsoft.EntityFrameworkCore;
using EquipmentStorage.Data.DTOs;

namespace EquipmentStorage.Data.Services
{
    public class EquipmentService
    {
        private EquipmentStorageContext _context;
        public EquipmentService(EquipmentStorageContext context)
        {
            _context = context;
        }

        public async Task<List<EquipmentDTO>> GetEquipments()
        {
            List<EquipmentDTO> equipmentDTOs = new List<EquipmentDTO>();

            var result = await _context.Equipment.Include(e => e.CategoryEquipment).Include(e => e.Condition).ToListAsync();
            result.ForEach(r => equipmentDTOs.Add(new EquipmentDTO
            {
                Id = r.Id,
                Cost_rent = r.Cost_rent,
                Category = r.CategoryEquipment.Category,
                Orientation = r.CategoryEquipment.Orientation,
                Name = r.Name,
                PhotoPath = r.PhotoPath,
                Type = r.CategoryEquipment.Type.ToString(),
                Condition = r.Condition.Name.ToString()
            }));

            return await Task.FromResult(equipmentDTOs);
        }

        public async Task<EquipmentMoreDTO> GetEquipment(int id)
        {
          
            Equipment? r = _context.Equipment.Include(e => e.CategoryEquipment).Include(e => e.Condition).FirstOrDefault(e => e.Id == id);

            EquipmentMoreDTO equipment = new EquipmentMoreDTO{
                Id = r.Id,
                InventoryNumber = r.InventoryNumber,
                Cost_rent = r.Cost_rent,
                CategoryEquipment = r.CategoryEquipment,
                Color=r.Color,
                Condition=r.Condition,
                Cost=r.Cost,
                Description=r.Description,
                Name=r.Name,
                PhotoPath=r.PhotoPath,
                Problems=r.Problems,
                Producer=r.Producer,
                ProductionDate=r.ProductionDate,
                Property1=r.Property1,
                Property2=r.Property2,
                StorageLocation=r.StorageLocation,
                Weight=r.Weight
            };
            return await Task.FromResult(equipment);
        }

        public async Task<List<EquipmentDTO>> GetEquipmentsWithConditionId(int id)
        {
            List<EquipmentDTO> equipmentDTOs = new List<EquipmentDTO>();

            var result = await _context.Equipment.Include(e => e.CategoryEquipment).Include(e => e.Condition).ToListAsync();
            foreach (Equipment equipment in result)
            {
                if (equipment.Condition.Id == id)
                {
                    equipmentDTOs.Add(new EquipmentDTO
                    {
                        Id = equipment.Id,
                        Category = equipment.CategoryEquipment.Category,
                        Orientation = equipment.CategoryEquipment.Orientation,
                        Cost_rent = equipment.Cost_rent,
                        Name = equipment.Name,
                        PhotoPath = equipment.PhotoPath,
                        Type = equipment.CategoryEquipment.Type.ToString(),
                        Condition = equipment.Condition.Name.ToString()
                    });
                }

            }
           
            return await Task.FromResult(equipmentDTOs);
        }


        public async Task<List<EquipmentDTO>> GetEquipmentsWithCategoryId(int id)
        {
            List<EquipmentDTO> equipmentDTOs = new List<EquipmentDTO>();

            var result = await _context.Equipment.Include(e => e.CategoryEquipment).Include(e => e.Condition).ToListAsync();
            foreach (Equipment equipment in result)
            {
                if (equipment.CategoryEquipment.Id == id)
                {
                    equipmentDTOs.Add(new EquipmentDTO
                    {
                        Id = equipment.Id,
                        Category = equipment.CategoryEquipment.Category,
                        Orientation = equipment.CategoryEquipment.Orientation,
                        Cost_rent = equipment.Cost_rent,
                        Name = equipment.Name,
                        PhotoPath = equipment.PhotoPath,
                        Type = equipment.CategoryEquipment.Type.ToString(),
                        Condition = equipment.Condition.Name.ToString()
                    });
                }

            }

            return await Task.FromResult(equipmentDTOs);
        }


        public async Task<List<EquipmentDTO>> GetEquipmentsWithOrientationName(string name)
        {
            List<EquipmentDTO> equipmentDTOs = new List<EquipmentDTO>();

            var result = await _context.Equipment.Include(e => e.CategoryEquipment).Include(e => e.Condition).ToListAsync();
            foreach (Equipment equipment in result)
            {
                if (equipment.CategoryEquipment.Orientation.Equals(name))
                {
                    Console.WriteLine(equipment.CategoryEquipment.Orientation.Equals(name));
                    equipmentDTOs.Add(new EquipmentDTO
                    {
                        Id = equipment.Id,
                        Category = equipment.CategoryEquipment.Category,
                        Orientation = equipment.CategoryEquipment.Orientation,
                        Cost_rent = equipment.Cost_rent,
                        Name = equipment.Name,
                        PhotoPath = equipment.PhotoPath,
                        Type = equipment.CategoryEquipment.Type.ToString(),
                        Condition = equipment.Condition.Name.ToString()
                    });
                }

            }

            return await Task.FromResult(equipmentDTOs);
        }

        public async Task<List<EquipmentDTO>> GetEquipmentsWithCategoryName(string name)
        {
            List<EquipmentDTO> equipmentDTOs = new List<EquipmentDTO>();

            var result = await _context.Equipment.Include(e => e.CategoryEquipment).Include(e => e.Condition).ToListAsync();
            foreach (Equipment equipment in result)
            {
                if (equipment.CategoryEquipment.Category.Equals(name))
                {
                    Console.WriteLine(equipment.CategoryEquipment.Orientation.Equals(name));
                    equipmentDTOs.Add(new EquipmentDTO
                    {
                        Id = equipment.Id,
                        Category = equipment.CategoryEquipment.Category,
                        Orientation = equipment.CategoryEquipment.Orientation,
                        Cost_rent = equipment.Cost_rent,
                        Name = equipment.Name,
                        PhotoPath = equipment.PhotoPath,
                        Type = equipment.CategoryEquipment.Type.ToString(),
                        Condition = equipment.Condition.Name.ToString()
                    });
                }

            }

            return await Task.FromResult(equipmentDTOs);
        }

        public async Task<List<EquipmentDTO>> GetEquipmentsByName(string name)
        {
            List<EquipmentDTO> equipmentDTOs = new List<EquipmentDTO>();

            var result = await _context.Equipment.Include(e => e.CategoryEquipment).Include(e => e.Condition).ToListAsync();
            foreach (Equipment equipment in result)
            {
                if (equipment.Name.ToLower().Contains(name.ToLower()) |
                    equipment.CategoryEquipment.Type.ToLower().Contains(name.ToLower()) |
                    equipment.CategoryEquipment.Orientation.ToLower().Contains(name.ToLower()) |
                    equipment.CategoryEquipment.Category.ToLower().Contains(name.ToLower()) |
                    (equipment.Description!=null && equipment.Description.ToLower().Contains(name.ToLower())))
                {
                    Console.WriteLine(equipment.CategoryEquipment.Orientation.Equals(name));
                    equipmentDTOs.Add(new EquipmentDTO
                    {
                        Id = equipment.Id,
                        Category = equipment.CategoryEquipment.Category,
                        Orientation = equipment.CategoryEquipment.Orientation,
                        Cost_rent = equipment.Cost_rent,
                        Name = equipment.Name,
                        PhotoPath = equipment.PhotoPath,
                        Type = equipment.CategoryEquipment.Type.ToString(),
                        Condition = equipment.Condition.Name.ToString()
                    });
                }

            }

            return await Task.FromResult(equipmentDTOs);
        }

        
        /*
        public async Task<List<IncompleteEquipmentDTO>> GetIncompleteEquipmentDTOs()
        {
            var equipment = await _context.Equipment.ToListAsync();
            List<IncompleteEquipmentDTO> result = new List<IncompleteEquipmentDTO>();
            equipment.ForEach(eq => result.Add(new IncompleteEquipmentDTO {Id = eq.Id, Name = eq.Name,Type = eq.CategoryEquipment.Type,
                PhotoPath = eq.PhotoPath, Cost_rent = eq.Cost_rent }));
            return await Task.FromResult(result);
        }
        
        */
        public async Task<Equipment?> AddEquipment(EquipmentAddDTO equipment)
        {
            Equipment nequipment = new Equipment
            {
                Name = equipment.Name,
                CategoryEquipment = _context.CategoryEquipment.FirstOrDefault(e => e.Id == equipment.CategoryEquipmentId),
                InventoryNumber = equipment.InventoryNumber,
                Color = equipment.Color,
                Property1 = equipment.Property1,
                Property2 = equipment.Property2,
                PhotoPath = equipment.PhotoPath,
                Producer = equipment.Producer,
                Weight = equipment.Weight,
                Cost = equipment.Cost,
                Cost_rent = equipment.Cost_rent,
                ProductionDate = equipment.ProductionDate,
                Description = equipment.Description,
                Condition = _context.Condition.FirstOrDefault(c => c.Id == equipment.ConditionId),
                Problems = equipment.Problems,
                StorageLocation = equipment.StorageLocation,
            };


            var result = _context.Equipment.Add(nequipment);
            await _context.SaveChangesAsync();
            return await Task.FromResult(result.Entity);
        }

    }
}

