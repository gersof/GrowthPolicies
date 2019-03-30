using GrowthPolicies.DataAccess.Configuration;
using GrowthPolicies.Models.AccountModels;
using GrowthPolicies.Models.PolicesModels;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace GrowthPolicies.DataAccess
{
    /// <summary>
    /// 
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        /// <summary>
        /// 
        /// </summary>
        private const string ConnectionString = "GrowthPoliciesConnection";

        /// <summary>
        /// 
        /// </summary>
        public DbSet<PolicyModel> Policies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<CoverageModel> Coverages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<RiskModel> Risks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<UserPolicyModel> UserPolicies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ApplicationDbContext()
            : base(ConnectionString, throwIfV1Schema: false)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PolicyConfiguration());
            modelBuilder.Configurations.Add(new CoverageConfiguration());
            modelBuilder.Configurations.Add(new RiskConfiguration());
            modelBuilder.Configurations.Add(new UserPolicyConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
   
