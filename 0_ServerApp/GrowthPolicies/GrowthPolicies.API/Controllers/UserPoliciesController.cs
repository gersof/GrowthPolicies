using GrowthPolicies.DataAccess;
using GrowthPolicies.DTO;
using GrowthPolicies.Repositories;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace GrowthPolicies.API.Controllers
{
    [Authorize(Roles = "client, admin")]
    [EnableCors("http://localhost:4200", "*", "*")]
    public class UserPoliciesController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserPoliciesController()
        {
            _unitOfWork = new UnitOfWork(new ApplicationDbContext());
        }

        // GET: api/Policies/5

        public IEnumerable<UserPolicyResponseDTO> Get(string id)
        {
            var userpolicies = _unitOfWork.UserPolicies.GetUserPolicies(id);
            return userpolicies;
        }

        // POST: api/Policies
        [Authorize(Roles = "admin")]
        public string Post([FromBody]UserPolicyDTO userpolicy)
        {
            var result = _unitOfWork.UserPolicies.AddUserPolicy(userpolicy);
            _unitOfWork.Complete();
            return result;
        }

        // DELETE: api/Policies/5
        [Authorize(Roles = "admin")]
        public void Delete(int id)
        {
            _unitOfWork.Policies.DeletePolicy(id);
            _unitOfWork.Complete();
        }
    }
}

