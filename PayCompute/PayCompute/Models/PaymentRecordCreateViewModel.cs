using PayCompute.Entity;
using System;
using System.ComponentModel.DataAnnotations;

namespace PayCompute.Models
{
    public class PaymentRecordCreateViewModel
    {
        public int Id { get; set; }

        [Display(Name ="FullName")]
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
        public string FullName { get; set; }
        public string SSN { get; set; } //social security No.

        [DataType(DataType.Date), Display(Name = "Pay Date")]
        public DateTime PayDate { get; set; } = DateTime.Now;

        [Display(Name = "Pay Month")]
        public string PayMonth { get; set; } = DateTime.Today.Month.ToString();

        [Display(Name ="TaxYear")]
        public int TaxYearId { get; set; }

        public TaxYear TaxYear { get; set; }
        public string TaxCode { get; set; } = "1040";

        [Display(Name = "Hourly Rate")]
        public decimal HourlyRate { get; set; }

        [Display(Name = "Hours Worked")]
        public decimal HoursWorked { get; set; }

        [Display(Name = "Contractual Hours")]
        public decimal ContractualHours { get; set; } = 144m;

        public decimal OvertimeHours { get; set; }
        public decimal ContractualEarnings { get; set; }
        public decimal OvertimeEarnings { get; set; }
        public decimal Tax { get; set; }
        public decimal FICA { get; set; } //Social Security
        public decimal? UnionFee { get; set; } //optional
        public Nullable<decimal> SLC { get; set; } //Student Loan Company. Does not apply to all employees
        public decimal TotalEarnings { get; set; }
        public decimal TotalDeduction { get; set; }
        public decimal NeyPayment { get; set; }
    }
}
