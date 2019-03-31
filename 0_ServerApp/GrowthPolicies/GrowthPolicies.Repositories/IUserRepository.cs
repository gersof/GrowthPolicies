using GrowthPolicies.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowthPolicies.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public interface IUserRepository
    {
        IEnumerable<UserDTO> GetUsers();
        UserDTO GetUser(string id);
        string DeleteUser(string id);
    }
}
