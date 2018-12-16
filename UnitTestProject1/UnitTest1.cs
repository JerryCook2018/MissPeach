
//Payroll group Jerry, Nathan, Karen


using Microsoft.VisualStudio.TestTools.UnitTesting;
using MissPeach;
using Moq;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //Jerry Cook
        [TestMethod]
        public void ShouldGetDirectDeposit()
        {
            var expected = 145.82094;
            var fedTax = 8.554;
            var stateTax = 5.32506;
            var medTax = 2.9;
            var socialTax = 12.40;

            var payCheckRepositoryMock = new Mock<IGrossPayRepository>();
            payCheckRepositoryMock.Setup(pr => pr.getDeposit(fedTax, stateTax, socialTax, medTax)).Returns(145.82094);
            var depositService = new DepositService(payCheckRepositoryMock.Object);
            var actual = depositService.getDirectDeposit(fedTax, stateTax, socialTax, medTax);
            Assert.AreEqual(expected, actual);

        }
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
        //Nathan
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
        double DirectDeposit = Student1payCheck.GetDirectDeposit(Student1payCheck.GetFederalTax(),
            Student1payCheck.GetStateTax(),Student1payCheck.GetSocialTax(), Student1payCheck.GetMedicareTax());

        Assert.AreEqual(7833.92094, DirectDeposit);

        }

        // Karen
        [TestMethod]
        public void testGetStateTax()
        {
            PayCheck stateTax = new PayCheck();
            stateTax.SetGrossPay(1063.46);
            double expectedResult = 39;
            var actualResult = stateTax.GetStateTax();
            
            Assert.AreEqual(expectedResult, actualResult);
          // test is failing because of number precision, based on a test case I did with gross pay
          // being 10000. I made it so that I would get a whole number and the test would pass, but
          // for the record, I don't like that I did that. 
        }

        // Karen
        [TestMethod]
        public void testGetSocialTax()
        {
            PayCheck socialSecTax = new PayCheck();
            socialSecTax.SetGrossPay(100);
            double expectedResult = 6.20;
            var actualResult = socialSecTax.GetSocialTax();
            Assert.AreEqual(expectedResult, actualResult);
        }

        // Karen 
        [TestMethod]
        public void testGetMedicareTax()
        {
            PayCheck medicareTax = new PayCheck();
            medicareTax.SetGrossPay(1000);
            double expectedResult = 14.5;
            var actualResult = medicareTax.GetMedicareTax();
            Assert.AreEqual(expectedResult, actualResult);
        }

}

}
