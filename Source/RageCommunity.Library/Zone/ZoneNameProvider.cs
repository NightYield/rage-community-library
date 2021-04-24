using System;
using System.Collections.Generic;

namespace RageCommunity.Library.Zone
{
    public static class ZoneNameProvider
    {
        /// <summary>
        /// A dictionary with all zone short- and full-names. 
        /// </summary>
        /// <remarks>
        /// Special thanks to DurtyFree for providing these names.
        /// https://github.com/DurtyFree/gta-v-data-dumps/blob/master/zones.json
        /// </remarks>
        public static Dictionary<String, String> ZoneNameDictionary = new Dictionary<String, String> (StringComparer.InvariantCultureIgnoreCase)
        {
            {"AirP", "Los Santos International Airport"},
            {"Alamo", "Alamo Sea"},
            {"Alta", "Alta"},
            {"ArmyB", "Fort Zancudo"},
            {"BanhamCa", "Banham"},
            {"Banning", "Banning"},
            {"Baytre", "Baytree Canyon"},
            {"Beach", "Vespucci Beach"},
            {"BhamCa", "Banham Canyon"},
            {"BradP", "Braddock Pass"},
            {"BradT", "Braddock Tunnel"},
            {"Burton", "Burton"},
            {"CalafB", "Calafia Bridge"},
            {"CANNY", "Raton Canyon"},
            {"CCreak", "Cassidy Creek"},
            {"ChamH", "Chamberlain Hills"},
            {"CHIL", "Vinewood Hills"},
            {"CHU", "Chumash"},
            {"CMSW", "Chiliad Mountain State Wilderness"},
            {"Cypre", "Cypress Flats"},
            {"Davis", "Davis"},
            {"Delbe", "Del Perro Beach"},
            {"DelPe", "Del Perro"},
            {"DelSol", "La Puerta"},
            {"Desrt", "Grand Senora Desert"},
            {"Downt", "Downtown"},
            {"DTVine", "Downtown Vinewood"},
            {"East_V", "East Vinewood"},
            {"EBuro", "El Burro Heights"},
            {"ELGorL", "El Gordo Lighthouse"},
            {"Elysian", "Elysian Island"},
            {"Galfish", "Galilee"},
            {"Galli", "Galileo Park"},
            {"Golf", "GWC and Golfing Society"},
            {"GrapeS", "Grapeseed"},
            {"Greatc", "Great Chaparral"},
            {"Harmo", "Harmony"},
            {"Hawick", "Hawick"},
            {"Hors", "Vinewood Racetrack"},
            {"HumLab", "Humane Labs and Research"},
            {"IsHeistZone", "Island"},
            {"Jail", "Bolingbroke Penitentiary"},
            {"Koreat", "Little Seoul"},
            {"LAct", "Land Act Reservoir"},
            {"Lago", "Lago Zancudo"},
            {"LDam", "Land Act Dam"},
            {"LegSqu", "Legion Square"},
            {"LMesa", "La Mesa"},
            {"LosPuer", "La Puerta"},
            {"Mirr", "Mirror Park"},
            {"Morn", "Morningwood"},
            {"Movie", "Richards Majestic"},
            {"MTChil", "Mount Chiliad"},
            {"MTGordo", "Mount Gordo"},
            {"MTJose", "Mount Josiah"},
            {"Murri", "Murrieta Heights"},
            {"NCHU", "North Chumash"},
            {"Noose", "N.O.O.S.E"},
            {"Observ", "Galileo Observatory"},
            {"Oceana", "Pacific Ocean"},
            {"PalCov", "Paleto Cove"},
            {"Paleto", "Paleto Bay"},
            {"PalFor", "Paleto Forest"},
            {"PalHigh", "Palomino Highlands"},
            {"Palmpow", "Palmer-Taylor Power Station"},
            {"PBluff", "Pacific Bluffs"},
            {"PBOX", "Pillbox Hill"},
            {"ProcoB", "Procopio Beach"},
            {"Prol", "North Yankton"},
            {"RANCHO", "Rancho"},
            {"RGLEN", "Richman Glen"},
            {"Richm", "Richman"},
            {"Rockf", "Rockford Hills"},
            {"RTRAK", "Redwood Lights Track"},
            {"SanChia", "San Chianski Mountain Range"},
            {"Sandy", "Sandy Shores"},
            {"SKID", "Mission Row"},
            {"Slab", "Stab City"},
            {"Stad", "Maze Bank Arena"},
            {"STRAW", "Strawberry"},
            {"Tatamo", "Tataviam Mountains"},
            {"Termina", "Terminal"},
            {"TEXTI", "Textile City"},
            {"TongvaH", "Tongva Hills"},
            {"TongvaV", "Tongva Valley"},
            {"VCana", "Vespucci Canals"},
            {"Vesp", "Vespucci"},
            {"Vine", "Vinewood"},
            {"WindF", "Ron Alternates Wind Farm"},
            {"WVine", "West Vinewood"},
            {"Zancudo", "Zancudo River"},
            {"ZP_ORT", "Port of South Los Santos"},
            {"zQ_UAR", "Davis Quartz"}
        };

        /// <summary>
        /// Returns the fullname for a zone short name. 
        /// </summary>
        /// <param name="shortName">The short name of a zone, eg. AIRP</param>
        /// <returns>The fullname of a zone, eg. Los Santos International Airport</returns>
        public static String GetFullname(String shortName)
        {
            return ZoneNameDictionary[shortName];
        }
    }
}