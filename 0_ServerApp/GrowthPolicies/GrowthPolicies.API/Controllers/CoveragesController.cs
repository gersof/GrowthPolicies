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
    public class CoveragesController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public CoveragesController()
        {
            _unitOfWork = new UnitOfWork(new ApplicationDbContext());
        }
        // GET: api/Coverages
        public IEnumerable<CoverageModel> Get()
        {
            var coverages = _unitOfWork.Coverages.GetCoverages();
            return coverages;
        }
    }
}
