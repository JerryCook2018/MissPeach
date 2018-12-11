
//miss peach project//
//payroll group//

using System;

namespace MissPeach
{
    public class Class1
    {
        static void  Main(string[] args)
        {
            PayCheck studentCheck = new PayCheck();
            //Test comment
            

        studentCheck.SetStudentFirstName("Tammy");
            studentCheck.SetStudentLastName("Carlone");
            studentCheck.SetMaritalStatus("Single");
            studentCheck.SetStudentId(235);
            studentCheck.SetGrossPay(10000);
            studentCheck.SetFedExemptions(1);
            studentCheck.SetStateExemptions(2);
            studentCheck.SetPayPeriod();
            studentCheck.GetDirectDeposit();

            WeeklyReport earningsStatement = new WeeklyReport(studentCheck);

            earningsStatement.printReport();
            Console.ReadKey();
    }
    }
}
