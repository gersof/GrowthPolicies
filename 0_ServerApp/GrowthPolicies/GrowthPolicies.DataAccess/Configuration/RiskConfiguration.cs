using GrowthPolicies.Models.PolicesModels;
using System.Data.Entity.ModelConfiguration;

namespace GrowthPolicies.DataAccess.Configuration
{
    public class RiskConfiguration : EntityTypeConfiguration<RiskModel>
    {
        public RiskConfiguration()
        {
            Property(p => p.Id)
                .IsRequired();

            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}
