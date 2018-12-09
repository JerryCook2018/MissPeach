
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
    }

}
