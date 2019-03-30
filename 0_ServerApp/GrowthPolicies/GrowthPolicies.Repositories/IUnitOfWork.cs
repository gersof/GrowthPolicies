using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowthPolicies.Repositories
{
    public interface IUnitOfWork
    {
        IPolicyRepository Policies { get; }
        ICoverageRepository Coverages { get; }
        IRiskRepository Risks { get; }
        IUserPolicyRepository UserPolicies { get; }
        IUserRepository Users { get; }
        void Complete();
    }
}
