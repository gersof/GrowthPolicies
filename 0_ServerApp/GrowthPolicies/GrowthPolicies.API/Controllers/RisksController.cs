using GrowthPolicies.DataAccess;
using GrowthPolicies.Models.PolicesModels;
using GrowthPolicies.Repositories;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace GrowthPolicies.API.Controllers
{
    [Authorize]
    [EnableCors("http://localhost:4200", "*", "*")]
    public class RisksController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public RisksController()
        {
            _unitOfWork = new UnitOfWork(new ApplicationDbContext());

        }
        // GET: api/Risks
        public IEnumerable<RiskModel> Get()
        {
            var risks = _unitOfWork.Risks.GetRisks();
            return risks;
        }
    }
}
