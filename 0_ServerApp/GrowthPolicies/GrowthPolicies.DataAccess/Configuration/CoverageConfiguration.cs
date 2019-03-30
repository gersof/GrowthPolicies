using GrowthPolicies.Models.PolicesModels;
using System.Data.Entity.ModelConfiguration;

namespace GrowthPolicies.DataAccess.Configuration
{
    public class CoverageConfiguration : EntityTypeConfiguration<CoverageModel>
    {
        public CoverageConfiguration()
        {
            Property(p => p.Id)
                .IsRequired();

            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(255);

        }
    }
}
