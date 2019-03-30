﻿using System.ComponentModel.DataAnnotations;

namespace GrowthPolicies.Models.PolicesModels
{
    /// <summary>
    /// 
    /// </summary>
    public class RiskModel
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}
