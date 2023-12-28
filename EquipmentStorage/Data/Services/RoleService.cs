using System;
using EquipmentStorage.Data.Models;
using EquipmentStorage.Data.DTOs;
using Microsoft.EntityFrameworkCore;

namespace EquipmentStorage.Data.Services
{
	public class RoleService
	{
        private EquipmentStorageContext _context;
        public RoleService(EquipmentStorageContext context)
        {
            _context = context;
        }

        public async Task<Role>? GetRole(int id)
        {
            var result = _context.Role.FirstOrDefault(r=>r.Id==id);
            return await Task.FromResult(result);
        }

        public async Task<List<Role>>? GetRoles()
        {
            var result = await _context.Role.ToListAsync();
            
            return await Task.FromResult(result);
        }

        public async Task<Role?> AddRole(Role role)
        {
            Role nrole = new Role
            {
                Name = role.Name,
            };
            var result = _context.Role.Add(nrole);
            await _context.SaveChangesAsync();
            return await Task.FromResult(result.Entity);
        }

    }
}

