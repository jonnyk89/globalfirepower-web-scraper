using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalFirePower.Models
{
    public class Country
    {
        public int CountrId { get; set; }
        public string CountryName { get; set; }
        public int Rank { get; set; }

        // Financials
        public string PurchasingPowerParity { get; set; }
        public string ForeignExchange { get; set; }
        public string DefenseBudget { get; set; }
        public string ExternalDebt { get; set; }

        // Geography
        public string SquareLandArea { get; set; }
        public string CoastlineCoverage { get; set; }
        public string SharedBorders { get; set; }
        public string Waterways { get; set; }

        // Manpower
        public string TotalPopulation { get; set; }
        public string AvailableManpower { get; set; }
        public string FitForService { get; set; }
        public string ReachingMilitaryAgeAnually { get; set; }
        public string TotalMilitaryPersonnel { get; set; }
        public string ActivePersonnel { get; set; }
        public string ReservePersonnel { get; set; }
        public string AirforcePersonnel { get; set; }
        public string ArmyPersonnel { get; set; }
        public string NavyPersonnel { get; set; }

        // Airpower
        public string TotalAircraft { get; set; }
        public string Fighters { get; set; }
        public string AttackTypes { get; set; }
        public string Transports { get; set; }
        public string Trainers { get; set; }
        public string SpecialMission { get; set; }
        public string TankerFleet { get; set; }
        public string Helicopters { get; set; }
        public string AttackHelicopters { get; set; }

        // Land Forces
        public string Tanks { get; set; }
        public string Vehicles { get; set; }
        public string SelfPropelledArtillery { get; set; }
        public string TowedArtillery { get; set; }
        public string RocketArtillery { get; set; }

        // Naval Forces
        public string TotalNavy { get; set; }
        public string AircraftCariiers { get; set; }
        public string HelicopterCarriers { get; set; }
        public string Destroyers { get; set; }
        public string Frigates { get; set; }
        public string Corvettes { get; set; }
        public string Submarines { get; set; }
        public string PatrolVessels { get; set; }
        public string MineWarfare { get; set; }

        // Natural Resources
        public string OilProduction { get; set; }
        public string OilConsumption { get; set; }
        public string OilDeficit { get; set; }
        public string OilReserves { get; set; }
        public string NaturalGasProduction { get; set; }
        public string NaturalGasConsumption { get; set; }
        public string NaturalGasDeficit { get; set; }
        public string NaturalGasReserves { get; set; }
        public string CoalProduction { get; set; }
        public string CoalConsumption { get; set; }
        public string CoalDeficit { get; set; }
        public string CoalReserves { get; set; }

        // Logistics
        public string LaborForce { get; set; }
        public string MerchantMarineFleet { get; set; }
        public string Ports { get; set; }
        public string Airports { get; set; }
        public string RoadwayCoverage { get; set; }
        public string RailwayCoverage { get; set; }
    }
}
