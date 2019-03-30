using GrowthPolicies.Models.PolicesModels;
using GrowthPolicies.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace GrowthPolicies.DataAccess.Repositories
{
    public class RiskRepository : IRiskRepository
    {
        private readonly ApplicationDbContext _context;

        public RiskRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<RiskModel> GetRisks()
        {
            return _context.Risks.ToList();
        }
    }
}
