using BlackPearl.Core.Entities;
using BlackPearl.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackPearl.API.Services
{
    public class RegressionService : IRegressionService
    {
        public IEnumerable<RegressionTest> GetTests()
        {
            var tests = new List<RegressionTest>
            {
                new RegressionTest{ Name = "Test One",
                                    Content="This is a lynear regression model test to predict the next forcast value for a given stock in the Colombo Stock exchange",
                                    Action = "VIEW"
                },
                new RegressionTest{ Name = "Test Two",
                                    Content="This is a lynear regression model test to predict the next forcast value for a given stock in the Colombo Stock exchange",
                                    Action = "VIEW"
                },
                new RegressionTest{ Name = "Test Three",
                                    Content="This is a lynear regression model test to predict the next forcast value for a given stock in the Colombo Stock exchange",
                                    Action = "VIEW"
                },
                new RegressionTest{ Name = "Test Four",
                                    Content="This is a lynear regression model test to predict the next forcast value for a given stock in the Colombo Stock exchange",
                                    Action = "VIEW"
                },
                new RegressionTest{ Name = "Test FIve",
                                    Content="This is a lynear regression model test to predict the next forcast value for a given stock in the Colombo Stock exchange",
                                    Action = "VIEW"
                },
                new RegressionTest{ Name = "Test six",
                                    Content="This is a lynear regression model test to predict the next forcast value for a given stock in the Colombo Stock exchange",
                                    Action = "VIEW"
                },
                new RegressionTest{ Name = "Test Seven",
                                    Content="This is a lynear regression model test to predict the next forcast value for a given stock in the Colombo Stock exchange",
                                    Action = "VIEW"
                }
            };

            return tests;
        }
    }
}
