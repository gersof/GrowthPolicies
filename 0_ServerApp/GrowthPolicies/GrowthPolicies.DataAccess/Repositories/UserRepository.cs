using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrowthPolicies.DTO;
using GrowthPolicies.Models.PolicesModels;
using GrowthPolicies.Repositories;

namespace GrowthPolicies.DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<UserDTO> GetUsers()
        {
            return _context.Users.Select(u => new UserDTO
            {
                Id = u.Id,
                Email = u.Email,
                UserName = u.UserName
            }).ToList();
        }

        public UserDTO GetUser(string id)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id);
            if (user != null)
                return new UserDTO
                {
                    Id = user.Id,
                    Email = user.Email,
                    UserName = user.UserName,
                };
            return null;
        }

        public string DeleteUser(string id)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id);

            if (user == null) return "error";

            var countUsPolices = _context.UserPolicies.Count(x => x.InsuredId.Equals(id));

            if (countUsPolices > 0) return "error, user has associate policies";

            _context.Users.Remove(user);
            return "ok";

        }
    }
}

