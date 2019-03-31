using GrowthPolicies.Models.PolicesModels;
using GrowthPolicies.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using GrowthPolicies.DataAccess;

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
