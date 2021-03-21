using System;
using System.Collections.Generic;
using System.Text;

namespace PayCompute.Services.Implementation
{
    public class TaxService : ITaxService
    {
        private decimal tax;
        public decimal TaxAmount(decimal totalAmount)
        {
            //Illinois tax bracket
            if (totalAmount <= 9950 && totalAmount >= 0)
            {
                tax = calculateTax(.10m, totalAmount);
            }
            else if (totalAmount > 9950 && totalAmount <= 40525)
            { 
                tax = calculateTax(.12m, totalAmount);
            }
            else if (totalAmount > 40525 && totalAmount <= 86375)
            {
                tax = calculateTax(.22m, totalAmount);
            }
            else if (totalAmount > 86375 && totalAmount <= 164925)
            {
                tax = calculateTax(.24m, totalAmount);
            }
            else if (totalAmount > 164925 && totalAmount <= 209425)
            {
                tax = calculateTax(.32m, totalAmount);
            }
            else if (totalAmount > 209425 && totalAmount <= 523600)
            {
                tax = calculateTax(.35m, totalAmount);
            }
            else if (totalAmount > 523600)
            {
                tax = calculateTax(.37m, totalAmount);
            }

            return tax;
        }

        private decimal calculateTax(decimal taxRate, decimal totalAmount)
        {
            return totalAmount * taxRate;
        }
    }
}
