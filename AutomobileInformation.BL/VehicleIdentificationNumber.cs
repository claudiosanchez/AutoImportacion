using System.Collections.Generic;

namespace AutomobileInformation.BL
{
    public class VehicleIdentificationNumber
    {
        private readonly string _vinNumber;
        private readonly IVinNumberDecoder _decoder;
        private bool _isAmericanBuilt;
        private bool _isValid;
        private AutoMaker _maker; // Based on WMI, Digits 1-3 
        private VehicleModel _model; // Vehicle Attributes 4-8
        private int _modelYear; // Lookup based on ModelYearCode

     

        internal VehicleIdentificationNumber(string vinNumber, IVinNumberDecoder decoder)
        {
            _vinNumber = vinNumber;
            _decoder = decoder;
            
            _maker = _decoder.DecodeAutoMaker(_vinNumber);
            _model = _decoder.DecodeVechicleModel(_vinNumber);
            _isAmericanBuilt = _decoder.IsAmericanMade(_vinNumber);
            _modelYear = _decoder.DecodeModelYear(_vinNumber);
            _isValid = Validate(_vinNumber);

           
        }

        public bool IsAmericanBuilt
        {
            get { return _isAmericanBuilt; }
        }

        

      

        private bool Validate(string vinNumber)
        {
            return true;
            //TODO: Implement
            // CheckDigit();
        }
    }
}