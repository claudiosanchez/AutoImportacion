﻿using System.Collections.Generic;
using System.Linq;

namespace AutomobileInformation.BL
{
    public class AutoMakerRepository : IAutoMakerRepository
    {
        #region Hardcoded Values

        private static readonly IDictionary<char, string> Countries = new Dictionary<char, string>
                                                                          {
                                                                              {'1', "USA"},
                                                                              {'2', "Canada"},
                                                                              {'3', "Mexico"},
                                                                              {'4', "USA"},
                                                                              {'5', "USA"},
                                                                              {'J', "Japan"},
                                                                              {'K', "Korea"},
                                                                              {'S', "England"},
                                                                              {'W', "Germany"},
                                                                              {'Z', "Italy"}

                                                                              //TODO: Complete this list
                                                                          };


        private static readonly IDictionary<string, string> Manufacturers = new Dictionary<string, string>
                                                                                {
                                                                                    // TODO: Remove the White spaces                                                                  
                                                                                    {"AFA", "Ford South Africa"},
                                                                                    {"AAV", "Volkswagen South Africa"},
                                                                                    {"JA3", "Mitsubishi"},
                                                                                    {
                                                                                        "JA",
                                                                                        "Isuzu                                                                 "
                                                                                    },
                                                                                    {
                                                                                        "JF",
                                                                                        "Fuji Heavy Industries (Subaru)                                        "
                                                                                    },
                                                                                    {
                                                                                        "JHM",
                                                                                        "Honda                                                                   "
                                                                                    },
                                                                                    {
                                                                                        "JHG",
                                                                                        "Honda                                                                   "
                                                                                    },
                                                                                    {
                                                                                        "JHL",
                                                                                        "Honda                                                                   "
                                                                                    },
                                                                                    {
                                                                                        "JK",
                                                                                        "Kawasaki (motorcycles)                                                "
                                                                                    },
                                                                                    {
                                                                                        "JM",
                                                                                        "Mazda                                                                 "
                                                                                    },
                                                                                    {
                                                                                        "JN",
                                                                                        "Nissan                                                                "
                                                                                    },
                                                                                    {
                                                                                        "JS",
                                                                                        "Suzuki                                                                "
                                                                                    },
                                                                                    {
                                                                                        "JT",
                                                                                        "Toyota                                                                "
                                                                                    },
                                                                                    {
                                                                                        "KL",
                                                                                        "Daewoo General Motors South Korea                                     "
                                                                                    },
                                                                                    {
                                                                                        "KM8",
                                                                                        "Hyundai                                                                 "
                                                                                    },
                                                                                    {
                                                                                        "KMH",
                                                                                        "Hyundai                                                                 "
                                                                                    },
                                                                                    {
                                                                                        "KNA",
                                                                                        "Kia                                                                     "
                                                                                    },
                                                                                    {
                                                                                        "KNB",
                                                                                        "Kia                                                                     "
                                                                                    },
                                                                                    {
                                                                                        "KNC",
                                                                                        "Kia                                                                     "
                                                                                    },
                                                                                    {
                                                                                        "KNM",
                                                                                        "Renault Samsung                                                         "
                                                                                    },
                                                                                    {
                                                                                        "KPA",
                                                                                        "Ssangyong                                                               "
                                                                                    },
                                                                                    {
                                                                                        "KPT",
                                                                                        "Ssangyong                                                               "
                                                                                    },
                                                                                    {
                                                                                        "L56",
                                                                                        "Renault Samsung                                                         "
                                                                                    },
                                                                                    {
                                                                                        "L5Y",
                                                                                        "Merato Motorcycle Taizhou Zhongneng                                     "
                                                                                    },
                                                                                    {
                                                                                        "LDY",
                                                                                        "Zhongtong Coach, China                                                  "
                                                                                    },
                                                                                    {
                                                                                        "LGH",
                                                                                        "Dong Feng (DFM), China                                                  "
                                                                                    },
                                                                                    {
                                                                                        "LKL",
                                                                                        "Suzhou King Long, China                                                 "
                                                                                    },
                                                                                    {
                                                                                        "LSY",
                                                                                        "Brilliance Zhonghua                                                     "
                                                                                    },
                                                                                    {
                                                                                        "LTV",
                                                                                        "Toyota Tian Jin                                                         "
                                                                                    },
                                                                                    {
                                                                                        "LVS",
                                                                                        "Ford Chang An                                                           "
                                                                                    },
                                                                                    {
                                                                                        "LVV",
                                                                                        "Chery, China                                                            "
                                                                                    },
                                                                                    {
                                                                                        "LZM",
                                                                                        "MAN China                                                               "
                                                                                    },
                                                                                    {
                                                                                        "LZE",
                                                                                        "Isuzu Guangzhou, China                                                  "
                                                                                    },
                                                                                    {
                                                                                        "LZG",
                                                                                        "Shaanxi Automobile Group, China                                         "
                                                                                    },
                                                                                    {
                                                                                        "LZY",
                                                                                        "Yutong Zhengzhou, China                                                 "
                                                                                    },
                                                                                    {
                                                                                        "MAL",
                                                                                        "Hyundai                                                                 "
                                                                                    },
                                                                                    {
                                                                                        "MA3",
                                                                                        "Suzuki India                                                            "
                                                                                    },
                                                                                    {
                                                                                        "MA7",
                                                                                        "Honda Siel Cars India                                                   "
                                                                                    },
                                                                                    {
                                                                                        "MHR",
                                                                                        "Honda Indonesia                                                         "
                                                                                    },
                                                                                    {
                                                                                        "MNB",
                                                                                        "Ford Thailand                                                           "
                                                                                    },
                                                                                    {
                                                                                        "MNT",
                                                                                        "Nissan Thailand                                                         "
                                                                                    },
                                                                                    {
                                                                                        "MMB",
                                                                                        "Mitsubishi Thailand                                                     "
                                                                                    },
                                                                                    {
                                                                                        "MMM",
                                                                                        "Chevrolet Thailand                                                      "
                                                                                    },
                                                                                    {
                                                                                        "MMT",
                                                                                        "Mitsubishi Thailand                                                     "
                                                                                    },
                                                                                    {
                                                                                        "MM8",
                                                                                        "Mazda Thailand                                                          "
                                                                                    },
                                                                                    {
                                                                                        "MPA",
                                                                                        "Isuzu Thailand                                                          "
                                                                                    },
                                                                                    {
                                                                                        "MP1",
                                                                                        "Isuzu Thailand                                                          "
                                                                                    },
                                                                                    {
                                                                                        "MRH",
                                                                                        "Honda Thailand                                                          "
                                                                                    },
                                                                                    {
                                                                                        "MR0",
                                                                                        "Toyota Thailand                                                         "
                                                                                    },
                                                                                    {
                                                                                        "NLE",
                                                                                        "Mercedes-Benz Turk Truck                                                "
                                                                                    },
                                                                                    {
                                                                                        "NM0",
                                                                                        "Ford Turkey                                                             "
                                                                                    },
                                                                                    {
                                                                                        "NM4",
                                                                                        "Tofas Turk                                                              "
                                                                                    },
                                                                                    {
                                                                                        "NMT",
                                                                                        "Toyota Turkiye                                                          "
                                                                                    },
                                                                                    {
                                                                                        "PE1",
                                                                                        "Ford Phillipines                                                        "
                                                                                    },
                                                                                    {
                                                                                        "PE3",
                                                                                        "Mazda Phillipines                                                       "
                                                                                    },
                                                                                    {
                                                                                        "PL1",
                                                                                        "Proton, Malaysia                                                        "
                                                                                    },
                                                                                    {
                                                                                        "SAL",
                                                                                        "Land Rover                                                              "
                                                                                    },
                                                                                    {
                                                                                        "SAJ",
                                                                                        "Jaguar                                                                  "
                                                                                    },
                                                                                    {
                                                                                        "SAR",
                                                                                        "Rover                                                                   "
                                                                                    },
                                                                                    {
                                                                                        "SCA",
                                                                                        "Rolls Royce                                                             "
                                                                                    },
                                                                                    {
                                                                                        "SCC",
                                                                                        "Lotus Cars                                                              "
                                                                                    },
                                                                                    {
                                                                                        "SCE",
                                                                                        "DeLorean Motor Cars N. Ireland (UK)                                     "
                                                                                    },
                                                                                    {
                                                                                        "SCF",
                                                                                        "Aston                                                                   "
                                                                                    },
                                                                                    {
                                                                                        "SDB",
                                                                                        "Peugeot UK                                                              "
                                                                                    },
                                                                                    {
                                                                                        "SFD",
                                                                                        "Alexander Dennis UK                                                     "
                                                                                    },
                                                                                    {
                                                                                        "SHS",
                                                                                        "Honda UK                                                                "
                                                                                    },
                                                                                    {
                                                                                        "SJN",
                                                                                        "Nissan UK                                                               "
                                                                                    },
                                                                                    {
                                                                                        "SU9",
                                                                                        "Solaris Bus & Coach (Poland)                                            "
                                                                                    },
                                                                                    {
                                                                                        "TK9",
                                                                                        "SOR (Czech Republic)                                                    "
                                                                                    },
                                                                                    {
                                                                                        "TDM",
                                                                                        "QUANTYA Swiss Electric Movement (Switzerland)                           "
                                                                                    },
                                                                                    {
                                                                                        "TMB",
                                                                                        "Škoda (Czech Republic)                                                  "
                                                                                    },
                                                                                    {
                                                                                        "TMK",
                                                                                        "Karosa (Czech Republic)                                                 "
                                                                                    },
                                                                                    {
                                                                                        "TMP",
                                                                                        "Škoda trolleybuses (Czech Republic)                                     "
                                                                                    },
                                                                                    {
                                                                                        "TMT",
                                                                                        "Tatra (Czech Republic)                                                  "
                                                                                    },
                                                                                    {
                                                                                        "TM9",
                                                                                        "Škoda trolleybuses (Czech Republic)                                     "
                                                                                    },
                                                                                    {
                                                                                        "TN9",
                                                                                        "Karosa (Czech Republic)                                                 "
                                                                                    },
                                                                                    {
                                                                                        "TRA",
                                                                                        "Ikarus Bus                                                              "
                                                                                    },
                                                                                    {
                                                                                        "TRU",
                                                                                        "Audi Hungary                                                            "
                                                                                    },
                                                                                    {
                                                                                        "TSE",
                                                                                        "Ikarus Egyedi Autobuszgyar, (Hungary)                                   "
                                                                                    },
                                                                                    {
                                                                                        "TSM",
                                                                                        "Suzuki, (Hungary)                                                       "
                                                                                    },
                                                                                    {
                                                                                        "UU1",
                                                                                        "Renault Dacia, (Romania)                                                "
                                                                                    },
                                                                                    {
                                                                                        "VF1",
                                                                                        "Renault                                                                 "
                                                                                    },
                                                                                    {
                                                                                        "VF3",
                                                                                        "Peugeot                                                                 "
                                                                                    },
                                                                                    {
                                                                                        "VF6",
                                                                                        "Renault (Trucks & Buses)                                                "
                                                                                    },
                                                                                    {
                                                                                        "VF7",
                                                                                        "Citroën                                                                 "
                                                                                    },
                                                                                    {
                                                                                        "VF8",
                                                                                        "Matra                                                                   "
                                                                                    },
                                                                                    {
                                                                                        "VNE",
                                                                                        "Irisbus (France)                                                        "
                                                                                    },
                                                                                    {
                                                                                        "VSE",
                                                                                        "Suzuki Spain (Santana Motors)                                           "
                                                                                    },
                                                                                    {
                                                                                        "VSK",
                                                                                        "Nissan Spain                                                            "
                                                                                    },
                                                                                    {
                                                                                        "VSS",
                                                                                        "SEAT                                                                    "
                                                                                    },
                                                                                    {
                                                                                        "VSX",
                                                                                        "Opel Spain                                                              "
                                                                                    },
                                                                                    {
                                                                                        "VS6",
                                                                                        "Ford Spain                                                              "
                                                                                    },
                                                                                    {
                                                                                        "VS9",
                                                                                        "Carrocerias Ayats (Spain)                                               "
                                                                                    },
                                                                                    {
                                                                                        "VWV",
                                                                                        "Volkswagen Spain                                                        "
                                                                                    },
                                                                                    {
                                                                                        "VX1",
                                                                                        "Zastava / Yugo Serbia                                                   "
                                                                                    },
                                                                                    {
                                                                                        "WAG",
                                                                                        "Neoplan                                                                 "
                                                                                    },
                                                                                    {
                                                                                        "WAU",
                                                                                        "Audi                                                                    "
                                                                                    },
                                                                                      {
                                                                                        "WA1",
                                                                                        "Audi" // Audi SUVs Q5 and Q7
                                                                                    },
                                                                                    {
                                                                                        "WBA",
                                                                                        "BMW                                                                     "
                                                                                    },
                                                                                    {
                                                                                        "WBS",
                                                                                        "BMW M                                                                   "
                                                                                    },
                                                                                    {
                                                                                        "WDB",
                                                                                        "Mercedes-Benz                                                           "
                                                                                    },
                                                                                    {
                                                                                        "WDC",
                                                                                        "DaimlerChrysler                                                         "
                                                                                    },
                                                                                    {
                                                                                        "WDD",
                                                                                        "McLaren                                                                 "
                                                                                    },
                                                                                    {
                                                                                        "WEB",
                                                                                        "Evobus GmbH (Mercedes-Bus)                                              "
                                                                                    },
                                                                                    {
                                                                                        "WF0",
                                                                                        "Ford Germany                                                            "
                                                                                    },
                                                                                    {
                                                                                        "WMA",
                                                                                        "MAN Germany                                                             "
                                                                                    },
                                                                                    {
                                                                                        "WMW",
                                                                                        "MINI                                                                    "
                                                                                    },
                                                                                    {
                                                                                        "WP0",
                                                                                        "Porsche                                                                 "
                                                                                    },
                                                                                    {
                                                                                        "W0L",
                                                                                        "Opel                                                                    "
                                                                                    },
                                                                                    {
                                                                                        "WVW",
                                                                                        "Volkswagen                                                              "
                                                                                    },
                                                                                    {
                                                                                        "WV1",
                                                                                        "Volkswagen Commercial Vehicles                                          "
                                                                                    },
                                                                                    {
                                                                                        "WV2",
                                                                                        "Volkswagen Bus/Van                                                      "
                                                                                    },
                                                                                    {
                                                                                        "XL9",
                                                                                        "Spyker                                                                  "
                                                                                    },
                                                                                    {
                                                                                        "XMC",
                                                                                        "Mitsubishi (NedCar)                                                     "
                                                                                    },
                                                                                    {
                                                                                        "XTA",
                                                                                        "Lada/AutoVaz (Russia)                                                   "
                                                                                    },
                                                                                    {
                                                                                        "YK1",
                                                                                        "Saab                                                                    "
                                                                                    },
                                                                                    {
                                                                                        "YS2",
                                                                                        "Scania AB                                                               "
                                                                                    },
                                                                                    {
                                                                                        "YS3",
                                                                                        "Saab                                                                    "
                                                                                    },
                                                                                    {
                                                                                        "YS4",
                                                                                        "Scania Bus                                                              "
                                                                                    },
                                                                                    {
                                                                                        "YV1",
                                                                                        "Volvo Cars                                                              "
                                                                                    },
                                                                                    {
                                                                                        "YV4",
                                                                                        "Volvo Cars                                                              "
                                                                                    },
                                                                                    {
                                                                                        "YV2",
                                                                                        "Volvo Trucks                                                            "
                                                                                    },
                                                                                    {
                                                                                        "YV3",
                                                                                        "Volvo Buses                                                             "
                                                                                    },
                                                                                    {
                                                                                        "ZAM",
                                                                                        "Maserati Biturbo                                                        "
                                                                                    },
                                                                                    {
                                                                                        "ZAP",
                                                                                        "Piaggio/Vespa/Gilera                                                    "
                                                                                    },
                                                                                    {
                                                                                        "ZAR",
                                                                                        "Alfa Romeo                                                              "
                                                                                    },
                                                                                    {
                                                                                        "ZCG",
                                                                                        "Cagiva SpA                                                              "
                                                                                    },
                                                                                    {
                                                                                        "ZDM",
                                                                                        "Ducati Motor Holdings SpA                                               "
                                                                                    },
                                                                                    {
                                                                                        "ZDF",
                                                                                        "Ferrari Dino                                                            "
                                                                                    },
                                                                                    {
                                                                                        "ZD4",
                                                                                        "Aprilia                                                                 "
                                                                                    },
                                                                                    {
                                                                                        "ZFA",
                                                                                        "Fiat                                                                    "
                                                                                    },
                                                                                    {
                                                                                        "ZFC",
                                                                                        "Fiat V.I.                                                               "
                                                                                    },
                                                                                    {
                                                                                        "ZFF",
                                                                                        "Ferrari                                                                 "
                                                                                    },
                                                                                    {
                                                                                        "ZHW",
                                                                                        "Lamborghini                                                             "
                                                                                    },
                                                                                    {
                                                                                        "ZLA",
                                                                                        "Lancia                                                                  "
                                                                                    },
                                                                                    {
                                                                                        "ZOM",
                                                                                        "OM                                                                      "
                                                                                    },
                                                                                    {
                                                                                        "1C3",
                                                                                        "Chrysler                                                                "
                                                                                    },
                                                                                    {
                                                                                        "1D3",
                                                                                        "Dodge                                                                   "
                                                                                    },
                                                                                    {
                                                                                        "1FA",
                                                                                        "Ford Motor Company                                                      "
                                                                                    },
                                                                                    {
                                                                                        "1FB",
                                                                                        "Ford Motor Company                                                      "
                                                                                    },
                                                                                    {
                                                                                        "1FC",
                                                                                        "Ford Motor Company                                                      "
                                                                                    },
                                                                                    {
                                                                                        "1FD",
                                                                                        "Ford Motor Company                                                      "
                                                                                    },
                                                                                    {
                                                                                        "1FM",
                                                                                        "Ford Motor Company                                                      "
                                                                                    },
                                                                                    {
                                                                                        "1FT",
                                                                                        "Ford Motor Company                                                      "
                                                                                    },
                                                                                    {
                                                                                        "1FU",
                                                                                        "Freightliner                                                            "
                                                                                    },
                                                                                    {
                                                                                        "1FV",
                                                                                        "Freightliner                                                            "
                                                                                    },
                                                                                    {
                                                                                        "1F9",
                                                                                        "FWD Corp.                                                               "
                                                                                    },
                                                                                    {
                                                                                        "1G",
                                                                                        "General Motors USA                                                    "
                                                                                    },
                                                                                    {
                                                                                        "1GC",
                                                                                        "Chevrolet Truck USA                                                     "
                                                                                    },
                                                                                    {
                                                                                        "1GT",
                                                                                        "GMC Truck USA                                                           "
                                                                                    },
                                                                                    {
                                                                                        "1G1",
                                                                                        "Chevrolet USA                                                           "
                                                                                    },
                                                                                    {
                                                                                        "1G2",
                                                                                        "Pontiac USA                                                             "
                                                                                    },
                                                                                    {
                                                                                        "1G3",
                                                                                        "Oldsmobile USA                                                          "
                                                                                    },
                                                                                    {
                                                                                        "1G4",
                                                                                        "Buick USA                                                               "
                                                                                    },
                                                                                    {
                                                                                        "1G6",
                                                                                        "Cadillac USA                                                            "
                                                                                    },
                                                                                    {
                                                                                        "1GM",
                                                                                        "Pontiac USA                                                             "
                                                                                    },
                                                                                    {
                                                                                        "1G8",
                                                                                        "Saturn USA                                                              "
                                                                                    },
                                                                                    {
                                                                                        "1H",
                                                                                        "Honda USA                                                             "
                                                                                    },
                                                                                    {
                                                                                        "1HD",
                                                                                        "Harley-Davidson                                                         "
                                                                                    },
                                                                                    {
                                                                                        "1J4",
                                                                                        "Jeep                                                                    "
                                                                                    },
                                                                                    {
                                                                                        "1L",
                                                                                        "Lincoln USA                                                           "
                                                                                    },
                                                                                    {
                                                                                        "1ME",
                                                                                        "Mercury USA                                                             "
                                                                                    },
                                                                                    {
                                                                                        "1M1",
                                                                                        "Mack Truck USA                                                          "
                                                                                    },
                                                                                    {
                                                                                        "1M2",
                                                                                        "Mack Truck USA                                                          "
                                                                                    },
                                                                                    {
                                                                                        "1M3",
                                                                                        "Mack Truck USA                                                          "
                                                                                    },
                                                                                    {
                                                                                        "1M4",
                                                                                        "Mack Truck USA                                                          "
                                                                                    },
                                                                                    {
                                                                                        "1N",
                                                                                        "Nissan USA                                                            "
                                                                                    },
                                                                                    {
                                                                                        "1NX",
                                                                                        "NUMMI USA                                                               "
                                                                                    },
                                                                                    {
                                                                                        "1P3",
                                                                                        "Plymouth USA                                                            "
                                                                                    },
                                                                                    {
                                                                                        "1R9",
                                                                                        "Roadrunner Hay Squeeze USA                                              "
                                                                                    },
                                                                                    {
                                                                                        "1VW",
                                                                                        "Volkswagen USA                                                          "
                                                                                    },
                                                                                    {
                                                                                        "1XK",
                                                                                        "Kenworth USA                                                            "
                                                                                    },
                                                                                    {
                                                                                        "1XP",
                                                                                        "Peterbilt USA                                                           "
                                                                                    },
                                                                                    {
                                                                                        "1YV",
                                                                                        "Mazda USA (AutoAlliance International)                                  "
                                                                                    },
                                                                                    {
                                                                                        "2C3",
                                                                                        "Chrysler Canada                                                         "
                                                                                    },
                                                                                    {
                                                                                        "2CN",
                                                                                        "CAMI                                                                    "
                                                                                    },
                                                                                    {
                                                                                        "2D3",
                                                                                        "Dodge Canada                                                            "
                                                                                    },
                                                                                    {
                                                                                        "2FA",
                                                                                        "Ford Motor Company Canada                                               "
                                                                                    },
                                                                                    {
                                                                                        "2FB",
                                                                                        "Ford Motor Company Canada                                               "
                                                                                    },
                                                                                    {
                                                                                        "2FC",
                                                                                        "Ford Motor Company Canada                                               "
                                                                                    },
                                                                                    {
                                                                                        "2FM",
                                                                                        "Ford Motor Company Canada                                               "
                                                                                    },
                                                                                    {
                                                                                        "2FT",
                                                                                        "Ford Motor Company Canada                                               "
                                                                                    },
                                                                                    {
                                                                                        "2FU",
                                                                                        "Freightliner                                                            "
                                                                                    },
                                                                                    {
                                                                                        "2FV",
                                                                                        "Freightliner                                                            "
                                                                                    },
                                                                                    {
                                                                                        "2FZ",
                                                                                        "Sterling                                                                "
                                                                                    },
                                                                                    {
                                                                                        "2G",
                                                                                        "General Motors Canada                                                 "
                                                                                    },
                                                                                    {
                                                                                        "2G1",
                                                                                        "Chevrolet Canada                                                        "
                                                                                    },
                                                                                    {
                                                                                        "2G2",
                                                                                        "Pontiac Canada                                                          "
                                                                                    },
                                                                                    {
                                                                                        "2G3",
                                                                                        "Oldsmobile Canada                                                       "
                                                                                    },
                                                                                    {
                                                                                        "2G4",
                                                                                        "Buick Canada                                                            "
                                                                                    },
                                                                                    {
                                                                                        "2HG",
                                                                                        "Honda Canada                                                            "
                                                                                    },
                                                                                    {
                                                                                        "2HK",
                                                                                        "Honda Canada                                                            "
                                                                                    },
                                                                                    {
                                                                                        "2HM",
                                                                                        "Hyundai Canada                                                          "
                                                                                    },
                                                                                    {
                                                                                        "2M",
                                                                                        "Mercury                                                               "
                                                                                    },
                                                                                    {
                                                                                        "2P3",
                                                                                        "Plymouth Canada                                                         "
                                                                                    },
                                                                                    {
                                                                                        "2T",
                                                                                        "Toyota Canada                                                         "
                                                                                    },
                                                                                    {
                                                                                        "2WK",
                                                                                        "Western Star                                                            "
                                                                                    },
                                                                                    {
                                                                                        "2WL",
                                                                                        "Western Star                                                            "
                                                                                    },
                                                                                    {
                                                                                        "2WM",
                                                                                        "Western Star                                                            "
                                                                                    },
                                                                                    {
                                                                                        "3D3",
                                                                                        "Dodge Mexico                                                            "
                                                                                    },
                                                                                    {
                                                                                        "3FE",
                                                                                        "Ford Motor Company Mexico                                               "
                                                                                    },
                                                                                    {
                                                                                        "3G",
                                                                                        "General Motors Mexico                                                 "
                                                                                    },
                                                                                    {
                                                                                        "3H",
                                                                                        "Honda Mexico                                                          "
                                                                                    },
                                                                                    {
                                                                                        "3N",
                                                                                        "Nissan Mexico                                                         "
                                                                                    },
                                                                                    {
                                                                                        "3P3",
                                                                                        "Plymouth Mexico                                                         "
                                                                                    },
                                                                                    {
                                                                                        "3VW",
                                                                                        "Volkswagen Mexico                                                       "
                                                                                    },
                                                                                    {
                                                                                        "4F",
                                                                                        "Mazda USA                                                             "
                                                                                    },
                                                                                    {
                                                                                        "4M",
                                                                                        "Mercury                                                               "
                                                                                    },
                                                                                    {
                                                                                        "4S",
                                                                                        "Subaru-Isuzu Automotive                                               "
                                                                                    },
                                                                                    {
                                                                                        "4T",
                                                                                        "Toyota                                                                "
                                                                                    },
                                                                                    {
                                                                                        "4US",
                                                                                        "BMW USA                                                                 "
                                                                                    },
                                                                                    {
                                                                                        "4UZ",
                                                                                        "Frt-Thomas Bus                                                          "
                                                                                    },
                                                                                    {
                                                                                        "4V1",
                                                                                        "Volvo                                                                   "
                                                                                    },
                                                                                    {
                                                                                        "4V2",
                                                                                        "Volvo                                                                   "
                                                                                    },
                                                                                    {
                                                                                        "4V3",
                                                                                        "Volvo                                                                   "
                                                                                    },
                                                                                    {
                                                                                        "4V4",
                                                                                        "Volvo                                                                   "
                                                                                    },
                                                                                    {
                                                                                        "4V5",
                                                                                        "Volvo                                                                   "
                                                                                    },
                                                                                    {
                                                                                        "4V6",
                                                                                        "Volvo                                                                   "
                                                                                    },
                                                                                    {
                                                                                        "4VL",
                                                                                        "Volvo                                                                   "
                                                                                    },
                                                                                    {
                                                                                        "4VM",
                                                                                        "Volvo                                                                   "
                                                                                    },
                                                                                    {
                                                                                        "4VZ",
                                                                                        "Volvo                                                                   "
                                                                                    },
                                                                                    {
                                                                                        "5F",
                                                                                        "Honda USA-Alabama                                                     "
                                                                                    },
                                                                                    {
                                                                                        "5L",
                                                                                        "Lincoln                                                               "
                                                                                    },
                                                                                    {
                                                                                        "5N1",
                                                                                        "Nissan USA                                                              "
                                                                                    },
                                                                                    {
                                                                                        "5NP",
                                                                                        "Hyundai USA                                                             "
                                                                                    },
                                                                                    {
                                                                                        "5T",
                                                                                        "Toyota USA - trucks                                                   "
                                                                                    },
                                                                                    {
                                                                                        "6AB",
                                                                                        "MAN Australia                                                           "
                                                                                    },
                                                                                    {
                                                                                        "6F4",
                                                                                        "Nissan Motor Company Australia                                          "
                                                                                    },
                                                                                    {
                                                                                        "6F5",
                                                                                        "Kenworth Australia                                                      "
                                                                                    },
                                                                                    {
                                                                                        "6FP",
                                                                                        "Ford Motor Company Australia                                            "
                                                                                    },
                                                                                    {
                                                                                        "6G1",
                                                                                        "General Motors-Holden (post Nov 2002)                                   "
                                                                                    },
                                                                                    {
                                                                                        "6G2",
                                                                                        "Pontiac Australia (GTO & G8)                                            "
                                                                                    },
                                                                                    {
                                                                                        "6H8",
                                                                                        "General Motors-Holden (pre Nov 2002)                                    "
                                                                                    },
                                                                                    {
                                                                                        "6MM",
                                                                                        "Mitsubishi Motors Australia                                             "
                                                                                    },
                                                                                    {
                                                                                        "6T1",
                                                                                        "Toyota Motor Corporation Australia                                      "
                                                                                    },
                                                                                    {
                                                                                        "6U9",
                                                                                        "Privately Imported car in Australia                                     "
                                                                                    },
                                                                                    {
                                                                                        "8AG",
                                                                                        "Chevrolet Argentina                                                     "
                                                                                    },
                                                                                    {
                                                                                        "8GG",
                                                                                        "Chevrolet Chile                                                         "
                                                                                    },
                                                                                    {
                                                                                        "8AP",
                                                                                        "Fiat Argentina                                                          "
                                                                                    },
                                                                                    {
                                                                                        "8AF",
                                                                                        "Ford Motor Company Argentina                                            "
                                                                                    },
                                                                                    {
                                                                                        "8AD",
                                                                                        "Peugeot Argentina                                                       "
                                                                                    },
                                                                                    {
                                                                                        "8GD",
                                                                                        "Peugeot Chile                                                           "
                                                                                    },
                                                                                    {
                                                                                        "8A1",
                                                                                        "Renault Argentina                                                       "
                                                                                    },
                                                                                    {
                                                                                        "8AK",
                                                                                        "Suzuki Argentina                                                        "
                                                                                    },
                                                                                    {
                                                                                        "8AJ",
                                                                                        "Toyota Argentina                                                        "
                                                                                    },
                                                                                    {
                                                                                        "8AW",
                                                                                        "Volkswagen Argentina                                                    "
                                                                                    },
                                                                                    {
                                                                                        "93U",
                                                                                        "Audi Brazil                                                             "
                                                                                    },
                                                                                    {
                                                                                        "9BG",
                                                                                        "Chevrolet Brazil                                                        "
                                                                                    },
                                                                                    {
                                                                                        "935",
                                                                                        "Citroën Brazil                                                          "
                                                                                    },
                                                                                    {
                                                                                        "9BD",
                                                                                        "Fiat Brazil                                                             "
                                                                                    },
                                                                                    {
                                                                                        "9BF",
                                                                                        "Ford Motor Company Brazil                                               "
                                                                                    },
                                                                                    {
                                                                                        "93H",
                                                                                        "Honda Brazil                                                            "
                                                                                    },
                                                                                    {
                                                                                        "9BM",
                                                                                        "Mercedes-Benz Brazil                                                    "
                                                                                    },
                                                                                    {
                                                                                        "936",
                                                                                        "Peugeot Brazil                                                          "
                                                                                    },
                                                                                    {
                                                                                        "93Y",
                                                                                        "Renault Brazil                                                          "
                                                                                    },
                                                                                    {
                                                                                        "9BS",
                                                                                        "Scania Brazil                                                           "
                                                                                    },
                                                                                    {
                                                                                        "93R",
                                                                                        "Toyota Brazil                                                           "
                                                                                    },
                                                                                    {
                                                                                        "9BW",
                                                                                        "Volkswagen Brazil                                                       "
                                                                                    },
                                                                                    {
                                                                                        "9FB",
                                                                                        "Renault Colombia                                                        "
                                                                                    },
                                                                                };

        #endregion

        public AutoMaker GetById(string autoMakeId)
        {
           var entry =  Manufacturers.FirstOrDefault(m => m.Key.Contains(autoMakeId));
           
                string country = Countries[autoMakeId[0]];
                return new AutoMaker(autoMakeId, entry.Value, autoMakeId[0], country);
            
        }
    }
}