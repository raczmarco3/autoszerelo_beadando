using AutoSzerelo_Munka_Felvevo_Kliens;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AddNewTests
{
    [TestClass]
    public class AddNewTests
    {
        [TestMethod]
        public void NotAcceptableLicensePlate_ShouldReturnFalse()
        {
            var newWindow = new AddNewWindow();
            string wrongLicensePlate = "BG-123";
            var result = newWindow.ValidateLicensePlate(wrongLicensePlate);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AcceptableLicensePlate_ShouldReturnTrue()
        {
            var newWindow = new AddNewWindow();
            string goodLicensePlate = "KLI-592";
            var result = newWindow.ValidateLicensePlate(goodLicensePlate);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void EmptyClientName_ShouldReturnFalse()
        {
            var newWindow = new AddNewWindow();
            string emtpyClientName = "";
            var result = newWindow.ValidateClientName(emtpyClientName);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void NotEmptyClientName_ShouldReturnTrue()
        {
            var newWindow = new AddNewWindow();
            string clientName = "Tóth János";
            var result = newWindow.ValidateClientName(clientName);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void EmptyCarType_ShouldReturnFalse()
        {
            var newWindow = new AddNewWindow();
            string emtpyCarType = "";
            var result = newWindow.ValidateCarType(emtpyCarType);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void NotEmptyCarType_ShouldReturnTrue()
        {
            var newWindow = new AddNewWindow();
            string carType = "Tóth János";
            var result = newWindow.ValidateCarType(carType);
            Assert.IsTrue(result);
        }
    }
}
