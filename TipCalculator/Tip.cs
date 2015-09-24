using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator
{
    public class Tip
    {
        public string BillAmount { get; set; }
        public string TipAmount { get; set; }
        public double TipAmountDouble { get; set; }
        public string TotalAmount { get; set; }
        public double TotalAmountDouble { get; set; }

        public Tip()
        {
            this.BillAmount = String.Empty;
            this.TipAmount = String.Empty;
            this.TipAmountDouble = 0;
            this.TotalAmountDouble = 0;
            this.TotalAmount = String.Empty;
        }

        public void CalculateTip(string originalAmount, double tipPercentage)
        {
            double billAmount = 0.0;
            double tipAmount = 0.0;
            double totalAmount = 0.0;

            if (double.TryParse(originalAmount.Replace('$', ' '), out billAmount))
            {
                tipAmount = billAmount * tipPercentage;
                TipAmountDouble = tipAmount;
                totalAmount = billAmount + tipAmount;
                TotalAmountDouble = totalAmount;
            }

            this.BillAmount = String.Format("{0:C}", billAmount);

            this.TipAmount = String.Format("{0:C}", tipAmount);
            this.TotalAmount = string.Format("{0:C}", totalAmount);
        }
    }
}
