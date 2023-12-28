using System;
using System.Collections.Generic;
using EquipmentStorage.Data.DTOs;
using EquipmentStorage.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EquipmentStorage.Data.Services
{
	public class UserDescriptionService
    {
        private EquipmentStorageContext _context;
        public UserDescriptionService(EquipmentStorageContext context)
        {
            _context = context;
        }

        public async Task<List<UserDescription>> GetUserDescriptions()
        {
            var result = await _context.UserDescriptions.Include(u=>u.Interests).Include(u=>u.Role).ToListAsync();
            
            return await Task.FromResult(result);
        }

        public async Task<UserDescription>? GetUserDescriptionsAuth(UserAuthLogPasDTO userAuthLogPasDTO)
        {
            UserDescription userDescription = new UserDescription();
            UserAuth user = new UserAuth();
            if (_context.UserAuth.ToList().Exists(u => u.Login.Equals(userAuthLogPasDTO.Login)))
            {
                user = _context.UserAuth.First(u => u.Login.Equals(userAuthLogPasDTO.Login));
                if (user!=null && user.Password.Equals(userAuthLogPasDTO.Password))
                {
                    userDescription = _context.UserDescriptions.Include(u => u.Interests).First(u=>u.UserId==user.Id);
                    
                    return await Task.FromResult(userDescription);
                }
            }
            return null;
        }

        public async Task<UserDescription?> AddUserDescription(UserDescriptionDTO userDescription)
        {
            UserDescription nuserDescription = new UserDescription
            {
                UserId = userDescription.Id,
                Name = userDescription.Name,
                Surname = userDescription.Surname,
                Patronymic = userDescription.Patronymic,
                Birthday = userDescription.Birthday, 
            };

            if (userDescription.Interests.Any())
            {
                nuserDescription.Interests = _context.Interests.ToList().IntersectBy(userDescription.Interests, interest => interest.Id).ToList();
            }

            var result = _context.UserDescriptions.Add(nuserDescription);
            await _context.SaveChangesAsync();
            return await Task.FromResult(result.Entity);
        }

        public async Task<UserDescription?> AddUserDataReg(UserDescrDataReg data)
        {
            UserDescription nuserDescription = new UserDescription
            {
                UserId = data.Id,
                Name = data.Name,
                Surname = data.Surname,
                Patronymic = data.Patronymic,
                Birthday = data.Birthday,
                Role = _context.Role.FirstOrDefault(r => r.Id == 1)
            };

            if (data.Interests.Any())
            {
                nuserDescription.Interests = _context.Interests.ToList().IntersectBy(data.Interests, interest => interest.Id).ToList();
            }
            var result = _context.UserDescriptions.Add(nuserDescription);
            await _context.SaveChangesAsync();
            return await Task.FromResult(result.Entity);
        }
    }
}

