
//Payroll group Jerry, Nathan, Karen


using Microsoft.VisualStudio.TestTools.UnitTesting;
using MissPeach;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //Jerry Cook
        [TestMethod]
        public void testReturnGrossPayFromPaycheckObject()
        {
            PayCheck pay = new PayCheck();
            pay.SetGrossPay(200.00);

            var expected = 200.00;
            var actual = pay.GetGrossPay();
            Assert.AreEqual(expected, actual);

        }
        //Jerry Cook
        [TestMethod]
        public void testFederalTaxReturn()
        {
            PayCheck pay = new PayCheck();
            pay.SetGrossPay(200.00);

            var expected = 8.554;
            var actual = pay.GetFederalTax();
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void testDirectDepositReturn()
        {

        PayCheck Student1payCheck = new PayCheck();

        Student1payCheck.SetStudentFirstName("Tammy");
            Student1payCheck.SetStudentLastName("Carlone");
            Student1payCheck.SetMaritalStatus("Single");
            Student1payCheck.SetStudentId(235);
            Student1payCheck.SetGrossPay(10000);
            Student1payCheck.SetFedExemptions(1);
            Student1payCheck.SetStateExemptions(2);

            WeeklyReport TammyReport = new WeeklyReport(Student1payCheck);
        // TammyReport.printReport();
        double DirectDeposit = Student1payCheck.GetDirectDeposit();

        Assert.AreEqual(2253.92094, DirectDeposit);

        }


}

}
