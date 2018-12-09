using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class WeeklyReport
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
            Console.Out.WriteLine("   Kelly Elementary School                                  Peroid Ending: {0}", payCheck.GetPayPeroid());
            Console.Out.WriteLine("   5150 RiverSide Drive                                     Pay Date:      {0}", payCheck.GetPayPeroid());
            Console.Out.WriteLine("   Marshall, MI 49068");

            Console.Out.WriteLine("   Taxable Marital Status: {0}", payCheck.GetMaritalStatus());
            Console.Out.WriteLine("   Exemptions/Allowences:");
            Console.Out.WriteLine("      Federal: {0}                                         {1} {2}", payCheck.GetFedExemptions(), payCheck.GetStudentFirstName(), payCheck.GetStudentLastName());
            Console.Out.WriteLine("      State:   {0}", payCheck.GetStateExemptions());
            Console.Out.WriteLine();
            Console.Out.WriteLine();
            Console.Out.WriteLine("   Earnings            rate              hours                this period         year to date");
            Console.Out.WriteLine("   ----------------------------------------------------------------------         ------------");
            Console.Out.WriteLine("   Regular             {0}                                    {1}                    {3}", payCheck.GetGrossPay(), payCheck.GetGrossPay(), payCheck.GetGrossPay());
            Console.Out.WriteLine("               Gross Pay                                      {0}                    {2}", payCheck.GetGrossPay(), payCheck.GetGrossPay());
            Console.Out.WriteLine();
            Console.Out.WriteLine("   Deductions  Statutory");
            Console.Out.WriteLine("               Federal Income Tax                            -{0}                    {1}", payCheck.GetFederalTax(), payCheck.GetFederalTax());
            Console.Out.WriteLine("               Social Security Tax                           -{0}                    {1}", payCheck.GetSocialTax(), payCheck.GetSocialTax());
            Console.Out.WriteLine("               Medicare Tax                                  -{0}                    {1}", payCheck.GetMedicareTax(), payCheck.GetMedicareTax());
            Console.Out.WriteLine("               MI State Income Tax                           -{0}                    {1}", payCheck.GetStateTax(), payCheck.GetStateTax());
            Console.Out.WriteLine();
            Console.Out.WriteLine("               Other");
            Console.Out.WriteLine("               ----------------------------------------------------------");
            Console.Out.WriteLine("               Direct Deposit                                -{0}                    {1}", payCheck.GetDirectDeposit(), payCheck.GetDirectDeposit());
            Console.Out.WriteLine();
            Console.Out.WriteLine("               Net Pay                                        $0.00");

        }
    }
}
