using System;
using EquipmentStorage.Data.Models;
using EquipmentStorage.Data.DTOs;
using Microsoft.EntityFrameworkCore;

namespace EquipmentStorage.Data.Services
{
	public class UserAuthService
	{
        private EquipmentStorageContext _context;
        public UserAuthService(EquipmentStorageContext context)
        {
            _context = context;
        }

        public async Task<List<UserAuth>> GetUsersAuth()
        {
            var result = await _context.UserAuth.Include(u=>u.Role).ToListAsync();
            return await Task.FromResult(result);

        }
        public async Task<ContactInformation> GetContactInformation(int id)
        {
            var result = await _context.UserAuth.Include(u => u.Role).ToListAsync();
            var user = result.FirstOrDefault(u => u.Id == id);
            var contact = new ContactInformation
            {
                Id = user.Id,
                Email = user.Email,
                Phone = user.Phone,
                Role = user.Role.Name,
            };
            return await Task.FromResult(contact);
        }
        public async Task<UserAuth?> AddUserAuth(UserAuthDTO userAuth)
        {
            UserAuth nuserAuth = new UserAuth
            {
                Login = userAuth.Login,
                Password = userAuth.Password,
                Email = userAuth.Email,
                Phone = userAuth.Phone,
                Role = _context.Role.FirstOrDefault(r=>r.Id==userAuth.RoleId),
            };


            var result = _context.UserAuth.Add(nuserAuth);
            await _context.SaveChangesAsync();
            return await Task.FromResult(result.Entity);
        }

            public async Task<UserAuth?> AddDataRegistration(UserAuthDataReg data)
        {
            foreach(UserAuth user in _context.UserAuth)
            {
                if (user.Login.Equals(data.Login))
                {
                    return null;
                }
            }
            UserAuth nuser = new UserAuth
            {
                Login = data.Login,
                Password = data.Password,
                Email = data.Email,
                Phone = data.Phone,
                Role = _context.Role.FirstOrDefault(r=>r.Id==1),
            };


            var result = _context.UserAuth.Add(nuser);
            await _context.SaveChangesAsync();
            
            return await Task.FromResult(result.Entity);
        }
    }
}

