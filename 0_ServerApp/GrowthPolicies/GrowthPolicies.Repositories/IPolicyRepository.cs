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
    public interface IPolicyRepository
    {
        PolicyDTO GetPolicy(int policyId);
        string AddPolicy(Policy policy);
        string UpdatePolicy(int id, Policy policy);
        string DeletePolicy(int id);
        IEnumerable<PolicyDto> GetPolicies();
        bool CheckIfRiskIsHigh(byte riskId);
        bool CheckCoveragePercentOver50(byte coverageId);
    }
}
