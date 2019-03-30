using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrowthPolicies.Models.PolicesModels
{
    /// <summary>
    /// 
    /// </summary>
    [Table("Policies")]
    public class PolicyModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartValidity { get; set; }
        public int CoverPeriod { get; set; }
        public decimal Price { get; set; }
        public CoverageModel Coverage { get; set; }
        public byte CoverageId { get; set; }
        public RiskModel Risk { get; set; }
        public byte RiskId { get; set; }
    }
}
