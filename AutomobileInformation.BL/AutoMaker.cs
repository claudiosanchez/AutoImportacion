// 
// AutoMaker.cs: 
// 
// Author: Claudio A. Sanchez
//
// Comments: Source Information came from 
// http://en.wikibooks.org/wiki/Vehicle_Identification_Numbers_(VIN_codes)/World_Manufacturer_Identifier_(WMI)
//

namespace AutomobileInformation.BL
{
    public class AutoMaker
    {
        public string Wmi { get; private set; }
        public string Manufacturer { get; private set; }
        public char CountryCode { get; private set; }
        public string CountryName { get; private set; }


        public AutoMaker(string wmi, string manufacturer, char countryCode, string countryName)
        {
            Wmi = wmi;
            Manufacturer = manufacturer;
            CountryName = countryName;
            CountryCode = countryCode;
        }
    }

}