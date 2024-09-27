using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Media;

namespace GlobalFirePower.Models
{
    public static class Constants
    {
        // Website
        public static readonly string BASE_URL_SITE = "https://www.globalfirepower.com/";
        public static readonly string BASE_URL_DETAILS = BASE_URL_SITE + "country-military-strength-detail.php?country_id=";
        public static readonly string PARENT_ELEMENT_TITLE = "//a[@title = '";
        public static readonly string PARENT_ELEMENT_TEXT = "//*[contains(text(),'";
        public static readonly string CHILD_VALUE_FROM_TITLE = "']/*[1]/*[5]/*[1]";
        public static readonly string CHILD_VALUE_FROM_TEXT = "')]/../*[3]/*[1]";

        /*
            By Title:
                
                //a[@title = 'Perchasing Power Parity (PPP) totals by country']/*[1]/*[5]/*[1]

            By Text:
            
                //*[contains(text(),'Tot Mil. Personnel (est.)')]/../*[3]/*[1]
        */

        // Countries (alphabetical order)
        public static readonly string AFG = "afghanistan";
        public static readonly string ALB = "albania";
        public static readonly string ALG = "algeria";
        public static readonly string ANG = "angola";
        public static readonly string ARG = "argentina";
        public static readonly string ARM = "armenia";
        public static readonly string AUS = "australia";
        public static readonly string AST = "austria";
        public static readonly string AZB = "azerbaijan";
        public static readonly string BAH = "bahrain";
        public static readonly string BNG = "bangladesh";
        public static readonly string BLR = "belarus";
        public static readonly string BEL = "belgium";
        public static readonly string BLZ = "beliz";
        public static readonly string BEN = "benin";
        public static readonly string BHU = "bhutan";
        public static readonly string BOL = "bolivia";
        public static readonly string BaH = "bosnia-and-herzegovina";
        public static readonly string BOT = "botswana";
        public static readonly string BRA = "brazil";
        public static readonly string BUL = "bulgaria";
        public static readonly string BrF = "burkina-faso";
        public static readonly string CBD = "cambodia";
        public static readonly string CMR = "cameroon";
        public static readonly string CAN = "canada";
        public static readonly string CAR = "central-african-republic";
        public static readonly string CHD = "chad";
        public static readonly string CHL = "chile";
        public static readonly string CHN = "china";
        public static readonly string COL = "colombia";
        public static readonly string CRO = "croatia";
        public static readonly string CUB = "cuba";
        public static readonly string CZE = "czech-republic";
        public static readonly string DRC = "democratic-republic-of-the-congo";
        public static readonly string DEN = "denmark";
        public static readonly string DOM = "dominican-republic";
        public static readonly string ECU = "ecuador";
        public static readonly string EGY = "egypt";
        public static readonly string ElS = "el-salvador";
        public static readonly string ERI = "eritrea";
        public static readonly string EST = "estonia";
        public static readonly string ETH = "ethiopia";
        public static readonly string FIN = "finland";
        public static readonly string FRA = "france";
        public static readonly string GAB = "gabon";
        public static readonly string GEO = "georgia";
        public static readonly string GER = "germany";
        public static readonly string GHA = "ghana";
        public static readonly string GRE = "greece";
        public static readonly string GUA = "guatemala";
        public static readonly string HON = "honduras";
        public static readonly string HUN = "hungary";
        public static readonly string ICE = "iceland";
        public static readonly string IDO = "indonesia";
        public static readonly string IND = "india";
        public static readonly string IRN = "iran";
        public static readonly string IRQ = "iraq";
        public static readonly string IRE = "ireland";
        public static readonly string ISR = "israel";
        public static readonly string ITA = "italy";
        public static readonly string IVO = "ivory-coast";
        public static readonly string JPN = "japan";
        public static readonly string JOR = "jordan";
        public static readonly string KAZ = "kazakhstan";
        public static readonly string KEN = "kenya";
        public static readonly string KOS = "kosovo";
        public static readonly string KUW = "kuwait";
        public static readonly string KYR = "kyrgyzstan";
        public static readonly string LAO = "laos";
        public static readonly string LAT = "latvia";
        public static readonly string LEB = "lebanon";
        public static readonly string LIB = "liberia";
        public static readonly string LBY = "libya";
        public static readonly string LTH = "lithuania";
        public static readonly string LUX = "luxembourg";
        public static readonly string MAC = "macedonia";
        public static readonly string MAD = "madagascar";
        public static readonly string MLY = "malaysia";
        public static readonly string MAL = "mali";
        public static readonly string MAU = "muritania";
        public static readonly string MEX = "mexico";
        public static readonly string MON = "mongolia";
        public static readonly string MOL = "moldova";
        public static readonly string MNT = "montenegro";
        public static readonly string MOR = "morocco";
        public static readonly string MOZ = "mozambique";
        public static readonly string MYA = "myanmar";
        public static readonly string NAM = "namibia";
        public static readonly string NEP = "nepal";
        public static readonly string NTH = "netherlands";
        public static readonly string NwZ = "new-zealand";
        public static readonly string NIC = "nicaragua";
        public static readonly string NGR = "niger";
        public static readonly string NGI = "nigeria";
        public static readonly string NoK = "north-korea";
        public static readonly string NOR = "norway";
        public static readonly string OMA = "oman";
        public static readonly string PAK = "pakistan";
        public static readonly string PAN = "panama";
        public static readonly string PAR = "paraguay";
        public static readonly string PER = "peru";
        public static readonly string PHL = "philippines";
        public static readonly string POL = "poland";
        public static readonly string POR = "portugal";
        public static readonly string QTR = "qatar";
        public static readonly string RoC = "republic-of-the-congo";
        public static readonly string ROM = "romania";
        public static readonly string RUS = "russia";
        public static readonly string SAU = "saudi-arabia";
        public static readonly string SEN = "senegal";
        public static readonly string SER = "serbia";
        public static readonly string SRL = "sierra-leone";
        public static readonly string SNG = "singapore";
        public static readonly string SLK = "slovakia";
        public static readonly string SLN = "slovenia";
        public static readonly string SOM = "somalia";
        public static readonly string SAF = "south-africa";
        public static readonly string SoK = "south-korea";
        public static readonly string SSD = "south-sudan";
        public static readonly string SPA = "spain";
        public static readonly string SrL = "sri-lanka";
        public static readonly string SUD = "sudan";
        public static readonly string SUR = "suriname";
        public static readonly string SWE = "sweden";
        public static readonly string SWZ = "switzerland";
        public static readonly string SYR = "syria";
        public static readonly string TWN = "taiwan";
        public static readonly string TAJ = "tajikistan";
        public static readonly string TAN = "tanzania";
        public static readonly string THL = "thailand";
        public static readonly string TUN = "tunisia";
        public static readonly string TUR = "turkey";
        public static readonly string TKM = "turkmenistan";
        public static readonly string UGA = "uganda";
        public static readonly string UKR = "ukraine";
        public static readonly string UAE = "united-arab-emirates";
        public static readonly string UK  = "united-kingdom";
        public static readonly string USA = "united-states-of-america";
        public static readonly string URG = "uruguay";
        public static readonly string UZB = "uzbekistan";
        public static readonly string VEN = "venezuela";
        public static readonly string VTN = "vietnam";
        public static readonly string YEM = "yemen";
        public static readonly string ZAM = "zambia";
        public static readonly string ZIM = "zimbabwe";

        // Financials
        public static readonly string PURCHASING_POWER_PARITY_TITLE = "Perchasing Power Parity (PPP) totals by country";
        public static readonly string FOREIGN_EXCHANGE_TITLE = "Reserves of Foreign Exchange and Gold totals by country";
        public static readonly string DEFENSE_BUDGET_TITLE = "Defense spending (USD) by military powers of globe";
        public static readonly string EXTERNAL_DEBT_TITLE = "External debt totals by country";

        // Geography
        public static readonly string SQUARE_LAND_AREA_TITLE = "Square land area in kilometers by country";
        public static readonly string COASTLINE_COVERAGE_TITLE = "Total coastline coverage in kilometers by country";
        public static readonly string SHARED_BORDERS_TITLE = "Total border coverage in kilometers by country";
        public static readonly string WATERWAYS_TITLE = "Total usable waterway coverage in kilometers by country";

        // Manpower
        public static readonly string TOTAL_POPULATION_TITLE = "Total populations listed by country";
        public static readonly string AVAILABLE_MANPOWER_TITLE = "Available military manpower listed by country";
        public static readonly string FIT_FOR_SERVICE_TITLE = "Population fit for military sevice listed by country";
        public static readonly string REACHING_MILITARY_AGE_ANUALLY = "Manpower reaching military age annually listed by country";
        public static readonly string TOTAL_MILITARY_PERSONNEL_TEXT = "Tot Mil. Personnel (est.)";
        public static readonly string ACTIVE_PERSONNEL_TITLE = "Active military manpower listed by country";
        public static readonly string RESERVE_PERSONNEL_TITLE = "Reserve military manpower listed by country";
        public static readonly string PARAMILITARY_TITLE = "Paramilitary forces strength by country";
        public static readonly string AIR_FORCE_PERSONNEL_TEXT = "Air Force Personnel*";
        public static readonly string ARMY_PERSONNEL_TEXT = "Army Personnel*";
        public static readonly string NAVY_PERSONNEL_TEXT = "Navy Personnel*";

        // Airpower
        public static readonly string TOTAL_AIRCRAFT_TITLE = "Total aircraft strength listed by country";
        public static readonly string FIGHTERS_TITLE = "Total fighter/combat aircraft strength listed by country";
        public static readonly string ATTACK_TYPES_TITLE = "Total attack aircraft strength listed by country";
        public static readonly string TRANSPORTS_TITLE = "Total fixed-wing transport aircraft strength listed by country";
        public static readonly string TRAINERS_TITLE = "Total military trainer aircraft strength listed by country";
        public static readonly string SPECIAL_MISSION_TITLE = "Total special-mission military aircraft strength listed by country";
        public static readonly string TANKER_FLEET_TITLE = "Total aerial tanker fleet strength listed by country";
        public static readonly string HELICOPTERS_TITLE = "Total military helicopter strength listed by country";
        public static readonly string ATTACK_HELICOPTERS_TITLE = "Total military attack helicopters strength listed by country";

        // Land Forces
        public static readonly string TANKS_TITLE = "Total combat tank strength listed by country";
        public static readonly string VEHICLES_TITLE = "Total Armored Fighting Vehicle (AFV) strength listed by country";
        public static readonly string SELF_PROPELLED_ARTILLERY_TITLE = "Total Self-Propelled Gun (SPG) vehicle strength listed by country";
        public static readonly string TOWED_ARTILLERY_TITLE = "Total towed field artillery strength listed by country";
        public static readonly string ROCKET_ARTILLERY_TITLE = "Total rocket projecting strength listed by country";

        // Naval Forces
        public static readonly string TOTAL_NAVY_TITLE = "Total navy fleet force strength listed by country";
        public static readonly string AIRCRAFT_CARRIERS_TITLE = "Total Aircraft Carrier fleet strength listed by country";
        public static readonly string HELICOPTER_CARRIERS_TITLE = "Total Helicopter Carrier force strength listed by country";
        public static readonly string DESTROYERS_TITLE = "Total Destroyer strength listed by country";
        public static readonly string FRIGATES_TITLE = "Total Frigate ship strength listed by country";
        public static readonly string CORVETTES_TITLE = "Total Corvette warship strength listed by country";
        public static readonly string SUBMARINES_TITLE = "Total Submarine fleet strength listed by country";
        public static readonly string PATROL_VESSELS_TITLE = "Total Offshore Patrol Vessel (OPV) force strength listed by country";
        public static readonly string MINE_WARFARE_TITLE = "Total Mine Warfare Craft strength listed by country";

        // Natural Resources
        public static readonly string OIL_PRODUCTION_TITLE = "Oil production by country list";
        public static readonly string OIL_CONSUMPTION_TITLE = "Oil consumption by country list";
        public static readonly string OIL_DEFICIT_TEXT = "Oil Deficit:";
        public static readonly string OIL_RESERVES_TITLE = "Proven oil reserves totals by country";
        public static readonly string NATURAL_GAS_PRODUCTION_TITLE = "Gas production by country list";
        public static readonly string NARUTAL_GAS_CONSUMPTION_TITLE = "Gas consumption by country list";
        public static readonly string NATURAL_GAS_DEFICIT_TEXT = "Natural Gas Deficit:";
        public static readonly string NATURAL_GAS_RESERVES_TITLE = "Proven gas reserves totals by country";
        public static readonly string COAL_PRODUCTION_TITLE = "Coal production by country list";
        public static readonly string COAL_CONSUMPTION_TITLE = "Coal consumption by country list";
        public static readonly string COAL_DEFICIT_TEXT = "Coal Deficit:";
        public static readonly string COAL_RESERVES_TITLE = "Proven coal reserves totals by country";

        // Logitics
        public static readonly string LABOR_FORCE_TITLE = "Labor Force totals by countries of the world";
        public static readonly string MERCHANT_MARINE_FLEET_TITLE = "Total Merchant Marine strench by country";
        public static readonly string PORTS_TITLE = "Total major ports and trade terminals by nation";
        public static readonly string AIRPORTS_TITLE = "Total serviceable airports by nation listing";
        public static readonly string ROADWAY_COVERAGE_TITLE = "Total roadway coverage (distance) by nation";
        public static readonly string RAILWAY_COVERAGE_TITLE = "Total railway coverage (distance) by nation";
    }
}
