using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Software_HardwareClasses;

namespace AgileProductsLTDtesting
{
    [TestClass]
    public class tstHardware
    {
        [TestMethod]
        public void HardwareTest()
        {
            clsHardware hardware = new clsHardware();
            Assert.IsNotNull(hardware);

        }

        [TestMethod]
        public void FineMethodOk()
        {
            clsHardware hardware = new clsHardware();

            Boolean Found = false;

            Found = hardware.Find(HardwareId);

            Assert.IsTrue(Found);
        }
    }
}