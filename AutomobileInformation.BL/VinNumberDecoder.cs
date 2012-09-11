using System;
using System.Collections.Generic;

namespace AutomobileInformation.BL
{
    public class VinNumberDecoder : IVinNumberDecoder
    {
        private readonly IAutoMakerRepository _autoMakerRepository;

        #region Reference Table for Years

        private readonly IDictionary<char, ushort> _years = new Dictionary<char, ushort>
                                                                {
                                                                    {'A', 0},
                                                                    {'B', 1},
                                                                    {'C', 2},
                                                                    {'D', 3},
                                                                    {'E', 4},
                                                                    {'F', 5},
                                                                    {'G', 6},
                                                                    {'H', 7},
                                                                    {'J', 8},
                                                                    {'K', 9},
                                                                    {'L', 10},
                                                                    {'M', 11},
                                                                    {'N', 12},
                                                                    {'P', 13},
                                                                    {'R', 14},
                                                                    {'S', 15},
                                                                    {'T', 16},
                                                                    {'V', 17},
                                                                    {'W', 18},
                                                                    {'X', 19},
                                                                    {'Y', 20},
                                                                    {'1', 21},
                                                                    {'2', 22},
                                                                    {'3', 23},
                                                                    {'4', 24},
                                                                    {'5', 25},
                                                                    {'6', 26},
                                                                    {'7', 27},
                                                                    {'8', 28},
                                                                    {'9', 29},
                                                                };

        #endregion

        public VinNumberDecoder(IAutoMakerRepository autoMakerRepository)
        {
            _autoMakerRepository = autoMakerRepository;
        }

        #region IVinNumberDecoder Members

        public virtual AutoMaker DecodeAutoMaker(string vinNumber)
        {
            var wmi = vinNumber.Substring(0, 3);

            var autoMaker = _autoMakerRepository.GetById(wmi);

            return autoMaker;
        }

        public virtual VehicleModel DecodeVechicleModel(string vinNumber)
        {
            return new VehicleModel();
        }

        public virtual bool IsAmericanMade(string vinNumber)
        {
            return (vinNumber[0] == '1' || vinNumber[0] == '4' || vinNumber[0] == '5');
        }

        public virtual int DecodeModelYear(string vinNumber)
        {
            var yearDigit = vinNumber[9];

            int baseYear = (char.IsDigit(vinNumber[6])) ? 1980 : 2010; // TODO: No Magic Numbers please

            int year = (_years.ContainsKey(yearDigit)) ? baseYear + _years[yearDigit] : 0;

            return year;
        }

        #endregion
    }

    public interface IVinNumberDecoder
    {
        AutoMaker DecodeAutoMaker(string vinNumber);
        VehicleModel DecodeVechicleModel(string vinNumber);
        bool IsAmericanMade(string vinNumber);
        int DecodeModelYear(string vinNumber);
    }
}