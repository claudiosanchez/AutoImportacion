using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomobileInformation.BL.Test
{
    [TestClass]
    public class VehicleInformationNumberTests
    {
       VehicleIndentificationNumberFactory _factory;
        
        [TestInitialize]
        public void SetupFixtures()
       {
           
           _factory = new VehicleIndentificationNumberFactory();
       }

        [TestMethod]
        public void TestMethod1()
        {
            var vin = _factory.BuildVehicleIdentificationNumberFromString("WA1DGBFE9BD002895");

            Assert.IsFalse(vin.IsAmericanBuilt); 

        }
    }
}