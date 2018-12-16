using System;
using System.Collections.Generic;
using System.Text;
//Jerry Cook
namespace MissPeach
{
   public interface IGrossPayRepository
    {
        double getDeposit(double fedTax, double stateTax, double socialTax, double medTax);
    }

    public class GrossPayRepository:IGrossPayRepository
    {
        private double grossPay = 200.00;
        private double deskRent = 25.00;
         
        double IGrossPayRepository.getDeposit(double fedTax, double stateTax, double socialTax, double medTax)
        {
            return grossPay - fedTax - stateTax - socialTax - medTax - deskRent;
        }
    }
}
