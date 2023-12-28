using System;
using EquipmentStorage.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EquipmentStorage.Data.Services
{
	public class InterestService
	{
        private EquipmentStorageContext _context;
        public InterestService(EquipmentStorageContext context)
        {
            _context = context;
        }

        public async Task<List<Interest>> GetInterests()
        {
            var result = await _context.Interests.ToListAsync();
            return await Task.FromResult(result);
        }

        public async Task<Interest?> AddInterest(Interest interest)
        {
            Interest ninterest = new Interest
            {
                Name = interest.Name
            };
            var result = _context.Interests.Add(ninterest);
            await _context.SaveChangesAsync();
            return await Task.FromResult(result.Entity);
        }
    }
}

