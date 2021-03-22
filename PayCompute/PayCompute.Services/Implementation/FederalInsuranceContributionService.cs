using System;
using System.Collections.Generic;
using System.Text;

namespace PayCompute.Services.Implementation
{
    public class FederalInsuranceContributionService : IFederalInsuranceContributionService
    {

        public decimal FederalInsuranceContribution(decimal totalAmount)
        {
            //Illinois Social Security and medicare tax rate
            decimal SSTax = totalAmount * 0.062m;
            decimal medicareTax = totalAmount * 0.0145m;

            return SSTax + medicareTax;
        }
    }
}
