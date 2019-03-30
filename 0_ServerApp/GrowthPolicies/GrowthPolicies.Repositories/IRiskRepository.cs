﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrowthPolicies.Models.PolicesModels;

namespace GrowthPolicies.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public interface IRiskRepository
    {
        IEnumerable<RiskModel> GetRisks();
    }
}
