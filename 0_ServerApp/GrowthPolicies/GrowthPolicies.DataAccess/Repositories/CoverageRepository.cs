using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrowthPolicies.Models.PolicesModels;
using GrowthPolicies.Repositories;

namespace GrowthPolicies.DataAccess.Repositories
{
    public class CoverageRepository : ICoverageRepository
    {
        private readonly ApplicationDbContext _context;

        public CoverageRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<CoverageModel> GetCoverages()
        {
            return _context.Coverages.ToList();
        }
    }
}
