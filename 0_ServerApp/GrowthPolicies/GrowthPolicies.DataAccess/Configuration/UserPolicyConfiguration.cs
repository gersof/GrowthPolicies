using GrowthPolicies.Models.PolicesModels;
using System.Data.Entity.ModelConfiguration;

namespace GrowthPolicies.DataAccess.Configuration
{
    public class UserPolicyConfiguration : EntityTypeConfiguration<UserPolicyModel>
    {
        public UserPolicyConfiguration()
        {
            HasKey(a => new { a.PolicyId, a.InsuredId });
        }
    }
}
