﻿using System.ComponentModel.DataAnnotations.Schema;
using GrowthPolicies.Models.AccountModels;

namespace GrowthPolicies.Models.PolicesModels
{
    /// <summary>
    /// 
    /// </summary>
    [Table("UserPolicies")]
    public class UserPolicyModel
    {
        public ApplicationUser Insured { get; set; }

        public PolicyModel Policy { get; set; }

        public int PolicyId { get; set; }

        public string InsuredId { get; set; }
    }
}
