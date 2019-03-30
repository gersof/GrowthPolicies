using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrowthPolicies.Models.PolicesModels
{
    /// <summary>
    /// 
    /// </summary>
    [Table("Risks")]
    public class RiskModel
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}
