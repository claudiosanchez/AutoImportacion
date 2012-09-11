namespace AutomobileInformation.BL
{
    public class VehicleIndentificationNumberFactory
    {
        public VehicleIdentificationNumber BuildVehicleIdentificationNumberFromString(string vehicleIdentificationNumber)
        {
            VehicleIdentificationNumber newVin = null;
            var normalizedVin = vehicleIdentificationNumber.ToUpperInvariant();

            //TODO: Evaluate VIN and determine the Decoder Implementation needed. For now, just return the default Impl.
            var decoder = new VinNumberDecoder(new AutoMakerRepository());

            newVin = new VehicleIdentificationNumber(normalizedVin, decoder);
            
            return newVin;
        }
    }
}