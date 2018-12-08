using System;
using System.Collections.Generic;
using System.Text;


namespace MissPeach
{
    class WeeklyReport
    {
         
        public WeeklyReport(PayCheck payCheck)
        {

        }
        
        public void printReport()
        {
            Console.Out.WriteLine("                                                            Earnings Statement");
            Console.Out.WriteLine();
            Console.Out.WriteLine("   Kelly Elementary School");
            Console.Out.WriteLine("   5150 RiverSide Drive                                     Period Ending:   {0}", payPeriodEndDate);
        }
    }
}
