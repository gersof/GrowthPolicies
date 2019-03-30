using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrowthPolicies.DTO;

namespace GrowthPolicies.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public interface IUserPolicyRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="insuranceId"></param>
        /// <returns></returns>
        IEnumerable<UserPolicyResponseDTO> GetUserPolicies(string insuranceId);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userPolicy"></param>
        /// <returns></returns>
        string AddUserPolicy(UserPolicyDTO userPolicy);
    }
}
