using GrowthPolicies.Models.PolicesModels;
using System.Data.Entity.ModelConfiguration;

namespace GrowthPolicies.DataAccess.Configuration
{
    public class PolicyConfiguration : EntityTypeConfiguration<PolicyModel>
    {
        public PolicyConfiguration()
        {
            Property(p => p.Id)
                .IsRequired();

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(255);

            Property(p => p.Description)
                .HasMaxLength(500);

            Property(p => p.CoverageId)
                .IsRequired();

            Property(p => p.RiskId)
                .IsRequired();
        }
    }
}
