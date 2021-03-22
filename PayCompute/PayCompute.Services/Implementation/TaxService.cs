using System;
using System.Collections.Generic;
using System.Text;

namespace PayCompute.Services.Implementation
{
    public class TaxService : ITaxService
    {
        public decimal TaxAmount(decimal totalAmount)
        {
            //Illinois tax bracket
            if (totalAmount <= 9950 && totalAmount >= 0)
            {
                return calculateTax(.10m, totalAmount);
            }
            else if (totalAmount > 9950 && totalAmount <= 40525)
            { 
                return calculateTax(.12m, totalAmount);
            }
            else if (totalAmount > 40525 && totalAmount <= 86375)
            {
                return calculateTax(.22m, totalAmount);
            }
            else if (totalAmount > 86375 && totalAmount <= 164925)
            {
                return calculateTax(.24m, totalAmount);
            }
            else if (totalAmount > 164925 && totalAmount <= 209425)
            {
                return calculateTax(.32m, totalAmount);
            }
            else if (totalAmount > 209425 && totalAmount <= 523600)
            {
                return calculateTax(.35m, totalAmount);
            }
            else if (totalAmount > 523600)
            {
                return calculateTax(.37m, totalAmount);
            }

            return 0;
        }

        private decimal calculateTax(decimal taxRate, decimal totalAmount)
        {
            return totalAmount * taxRate;
        }
    }
}
