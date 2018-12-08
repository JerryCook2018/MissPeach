using System;
using System.Collections.Generic;
using System.Text;



namespace MissPeach
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
            Console.Out.WriteLine("   Kelly Elementary School                                  Peroid Ending: {0}",payCheck.getPayPeroid());
            Console.Out.WriteLine("   5150 RiverSide Drive                                     Pay Date:      {0}",payCheck.getPayPeroid());
            Console.Out.WriteLine("   Marshall, MI 49068");

            Console.Out.WriteLine("   Taxable Marital Status: {0}", payCheck.getMaritalStatus());
            Console.Out.WriteLine("   Exemptions/Allowences:");
            Console.Out.WriteLine("      Federal: {0}"                                         , payCheck.getFedExemptions());
            Console.Out.WriteLine("      State:   {0}", payCheck.getStateExemptions());
            Console.Out.WriteLine();
     
        }
    }
}
