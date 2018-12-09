using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void testGetFederalTaxFromPaycheck()
        {
            PayCheck pay = new PayCheck();
            pay.SetGrossPay(200.00);

            string expected = "$200.00";
            string actual = pay.GetGrossPay();
            Assert.AreEqual(expected, actual);
        }
    }
}
