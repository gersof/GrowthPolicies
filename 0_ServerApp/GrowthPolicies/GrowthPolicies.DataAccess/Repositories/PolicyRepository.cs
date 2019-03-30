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
    public class PolicyRepository : IPolicyRepository
    {
        private readonly ApplicationDbContext _context;

        public PolicyRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public PolicyDTO GetPolicy(int policyId)
        {
            return _context.Policies
                .Include(p => p.Risk.Name)
                .Include(p => p.Coverage.Name).Select(x => new PolicyDTO
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    StartValidity = x.StartValidity,
                    CoverPeriod = x.CoverPeriod,
                    Price = x.Price,
                    CoverageName = x.Coverage.Name,
                    RiskName = x.Risk.Name,
                    RiskId = x.RiskId,
                    CoverageId = x.CoverageId,
                })
                .SingleOrDefault(p => p.Id == policyId);
        }

        public bool CheckCoveragePercentOver50(byte coverageId)
        {
            var coverage = _context.Coverages.FirstOrDefault(c => c.Id.Equals(coverageId));
            return (coverage != null && coverage.Cover > 50);
        }

        public bool CheckIfRiskIsHigh(byte riskId)
        {
            var risk = _context.Risks.FirstOrDefault(r => r.Id.Equals(riskId));
            return (risk != null && risk.Name.ToLower() == "alto");
        }


        public string AddPolicy(PolicyModel policy)
        {
            try
            {
                if (CheckIfRiskIsHigh(policy.RiskId))
                {
                    if (CheckCoveragePercentOver50(policy.CoverageId)) return "Error, coverage is over 50 percent";
                }
                _context.Policies.Add(policy);
                return "ok";
            }
            catch (Exception)
            {
                return "error";
            };
        }

        public string UpdatePolicy(int id, PolicyModel policy)
        {
            var currentPolicy = _context.Policies.Find(id);
            if (currentPolicy == null) return "error";
            _context.Entry(currentPolicy).CurrentValues.SetValues(policy);
            return "ok";
        }

        public string DeletePolicy(int id)
        {
            var currentPolicy = _context.Policies.Find(id);
            if (currentPolicy == null) return "error, policy not found";

            var associated = _context.UserPolicies.Count(x => x.PolicyId.Equals(id));
            if (associated > 0) return "error, this policy is currently associated";

            _context.Entry(currentPolicy).State = EntityState.Deleted;
            return "ok";
        }

        public IEnumerable<PolicyDTO> GetPolicies()
        {
            var policies = _context.Policies
                .Include(p => p.Risk)
                .Include(p => p.Coverage).Select(x => new PolicyDTO
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    StartValidity = x.StartValidity,
                    CoverPeriod = x.CoverPeriod,
                    Price = x.Price,
                    CoverageName = x.Coverage.Name,
                    RiskName = x.Risk.Name,
                    RiskId = x.RiskId,
                    CoverageId = x.CoverageId,
                }).ToList();

            return policies;
        }
    }
}
