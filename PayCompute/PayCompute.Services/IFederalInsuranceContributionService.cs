using System;
using System.Collections.Generic;
using System.Text;

namespace PayCompute.Services
{
    public interface IFederalInsuranceContributionService
    {
        decimal FederalInsuranceContribution(decimal totalAmount);
    }
}
