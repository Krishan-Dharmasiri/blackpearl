using BlackPearl.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlackPearl.Core.Services
{
    public interface IRegressionService
    {
        IEnumerable<RegressionTest> GetTests();
    }
}
