using System.ComponentModel.DataAnnotations.Schema;

namespace GrowthPolicies.Models.PolicesModels
{
    /// <summary>
    /// 
    /// </summary>
    [Table("Coverages")]
    public class CoverageModel
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public int Cover { get; set; }
    }
}
