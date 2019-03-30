using GrowthPolicies.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrowthPolicies.Models.PolicesModels;

namespace GrowthPolicies.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPolicyRepository
    {
        PolicyDTO GetPolicy(int policyId);
        string AddPolicy(PolicyModel policy);
        string UpdatePolicy(int id, PolicyModel policy);
        string DeletePolicy(int id);
        IEnumerable<PolicyDTO> GetPolicies();
        bool CheckIfRiskIsHigh(byte riskId);
        bool CheckCoveragePercentOver50(byte coverageId);
    }
}
