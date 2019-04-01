using GrowthPolicies.DataAccess;
using GrowthPolicies.DTO;
using GrowthPolicies.Models.PolicesModels;
using GrowthPolicies.Repositories;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;

namespace GrowthPolicies.API.Controllers
{
    [Authorize(Roles = "admin")]
    [EnableCorsAttribute("http://localhost:4200", "*", "*")]
    public class PoliciesController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public PoliciesController()
        {
            _unitOfWork = new UnitOfWork(new ApplicationDbContext());
        }

        // GET: api/Policies
        public IEnumerable<PolicyDTO> Get()
        {
            var policies = _unitOfWork.Policies.GetPolicies();
            return policies;
        }

        // GET: api/Policies/5
        public PolicyDTO Get(int id)
        {
            var policy = _unitOfWork.Policies.GetPolicy(id);
            return policy;
        }

        // POST: api/Policies
        public string Post([FromBody] PolicyModel policy)
        {
            var result = _unitOfWork.Policies.AddPolicy(policy);
            _unitOfWork.Complete();
            return result;
        }

        // PUT: api/Policies/5
        public OkNegotiatedContentResult<string> Put(int id, [FromBody] PolicyModel policy)
        {

            var result = _unitOfWork.Policies.UpdatePolicy(id, policy);
            _unitOfWork.Complete();
            return Ok(result);
        }

        // DELETE: api/Policies/5
        public OkNegotiatedContentResult<string> Delete(int id)
        {
            var result = _unitOfWork.Policies.DeletePolicy(id);
            _unitOfWork.Complete();
            return Ok(result);
        }
    }
}