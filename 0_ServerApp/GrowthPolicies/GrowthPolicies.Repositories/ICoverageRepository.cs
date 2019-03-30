using GrowthPolicies.Models.PolicesModels;
using System.Collections.Generic;

namespace GrowthPolicies.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICoverageRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerable<CoverageModel> GetCoverages();
    }
}
