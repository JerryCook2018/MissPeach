using System;
using System.Collections.Generic;
using System.Text;
//Jerry Cook
namespace MissPeach
{
   public interface IDepositService
    {
        double getDirectDeposit(double fedTax, double stateTax, double socialTax, double medTax);
    }
    public class DepositService:IDepositService
    {
        private readonly IGrossPayRepository _grossPayRepository;
        public DepositService(IGrossPayRepository grossPayRepository)
        {
            _grossPayRepository = grossPayRepository;
        }
        public double getDirectDeposit(double fedTax, double stateTax,double socialTax, double medTax)
        {
            return _grossPayRepository.getDeposit(fedTax, stateTax, socialTax, medTax);
        }
    }
}
