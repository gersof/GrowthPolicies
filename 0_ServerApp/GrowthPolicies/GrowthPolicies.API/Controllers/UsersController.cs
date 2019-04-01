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
    public class UsersController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public UsersController()
        {
            _unitOfWork = new UnitOfWork(new ApplicationDbContext());

        }

        // GET: api/Policies
        [Authorize(Roles = "admin")]
        public IEnumerable<UserDTO> Get()
        {
            var users = _unitOfWork.Users.GetUsers();
            return users;
        }

        // GET: api/Policies/5
        public UserDTO Get(string id)
        {
            var user = _unitOfWork.Users.GetUser(id);
            return user;
        }

        // DELETE: api/Policies/5
        [Authorize(Roles = "admin")]
        public string Delete(string id)
        {
            var result = _unitOfWork.Users.DeleteUser(id);
            _unitOfWork.Complete();
            return result;
        }
    }
}
