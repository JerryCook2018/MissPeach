//Payroll group Jerry, Nathan, Karen

using System;
using System.Collections.Generic;
using System.Text;



namespace MissPeach
{
  public  class WeeklyReport
    {
        PayCheck payCheck;
        public WeeklyReport(PayCheck payCheck)
        {
            this.payCheck = payCheck;
        }
        
        public void printReport()
        {
            Console.Out.WriteLine("                                                            Earnings Statement");
            Console.Out.WriteLine();
            Console.Out.WriteLine("   Kelly Elementary School                                  Peroid Ending: {0}",payCheck.GetPayPeroid());
            Console.Out.WriteLine("   5150 RiverSide Drive                                     Pay Date:      {0}",payCheck.GetPayPeroid());
            Console.Out.WriteLine("   Marshall, MI 49068");

            Console.Out.WriteLine("   Taxable Marital Status: {0}", payCheck.GetMaritalStatus());
            Console.Out.WriteLine("   Exemptions/Allowences:");
            Console.Out.WriteLine("      Federal: {0}                                         {1} {2}", payCheck.GetFedExemptions(),payCheck.GetStudentFirstName(),payCheck.GetStudentLastName());
            Console.Out.WriteLine("      State:   {0}", payCheck.GetStateExemptions());
            Console.Out.WriteLine();
            Console.Out.WriteLine();
            Console.Out.WriteLine("   Earnings            rate              hours                this period         year to date");
            Console.Out.WriteLine("   ----------------------------------------------------------------------         ------------");
            Console.Out.WriteLine("   Regular             {0}                                    {1}                    {2}", payCheck.GetGrossPay().ToString("C2"), payCheck.GetGrossPay().ToString("C2"), payCheck.GetGrossPay().ToString("C2"));
            Console.Out.WriteLine("               Gross Pay                                      {0}                    {1}", payCheck.GetGrossPay().ToString("C2"), payCheck.GetGrossPay().ToString("C2"));
            Console.Out.WriteLine();
            Console.Out.WriteLine("   Deductions  Statutory");
            Console.Out.WriteLine("               Federal Income Tax                            -{0}                    {1}", payCheck.GetFederalTax().ToString("F"), payCheck.GetFederalTax().ToString("F"));
            Console.Out.WriteLine("               Social Security Tax                           -{0}                    {1}", payCheck.GetSocialTax().ToString("F"), payCheck.GetSocialTax().ToString("F"));
            Console.Out.WriteLine("               Medicare Tax                                  -{0}                    {1}", payCheck.GetMedicareTax().ToString("F"), payCheck.GetMedicareTax().ToString("F"));
            Console.Out.WriteLine("               MI State Income Tax                           -{0}                    {1}", payCheck.GetStateTax().ToString("F"), payCheck.GetStateTax().ToString("F"));
            Console.Out.WriteLine();
            Console.Out.WriteLine("               Other");
            Console.Out.WriteLine("               ----------------------------------------------------------");
            Console.Out.WriteLine("               Direct Deposit                                {0}                    {1}", payCheck.GetDirectDeposit(payCheck.GetFederalTax(),payCheck.GetStateTax(),
                payCheck.GetSocialTax(),payCheck.GetMedicareTax()).ToString("C2"), payCheck.GetDirectDeposit(payCheck.GetFederalTax(), payCheck.GetStateTax()
                , payCheck.GetSocialTax(), payCheck.GetMedicareTax()).ToString("C2"));
            Console.Out.WriteLine();
            Console.Out.WriteLine("               Net Pay                                       {0}"                    , payCheck.GetDirectDeposit(payCheck.GetFederalTax(), payCheck.GetStateTax(),
                 payCheck.GetSocialTax(), payCheck.GetMedicareTax()).ToString("C2"));

        }
    }
}
