using System;
using EquipmentStorage.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EquipmentStorage.Data.Services
{
	public class ConditionService
	{
        private EquipmentStorageContext _context;
        public ConditionService(EquipmentStorageContext context)
        {
            _context = context;
        }

        public async Task<List<Condition>> GetConditions()
        {
            var result = await _context.Condition.ToListAsync();
            return await Task.FromResult(result);
        }

        public async Task<List<ConditionDTO>> GetConditionsDTO()
        {
            List<ConditionDTO> conditions = new List<ConditionDTO>();
            var result = await _context.Condition.ToListAsync();
            result.ForEach(r => conditions.Add(new ConditionDTO
            {
                Id = r.Id,
                Name = r.Name
            }));
            return await Task.FromResult(conditions);
        }

        public async Task<Condition?> AddCondition(Condition condition)
        {
            Condition ncondition = new Condition
            {
                Name = condition.Name
            };
            var result = _context.Condition.Add(ncondition);
            await _context.SaveChangesAsync();
            return await Task.FromResult(result.Entity);
        }
    }
}

