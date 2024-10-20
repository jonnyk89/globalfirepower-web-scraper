using GlobalFirePower.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GlobalFirePower.Controllers
{
    public class CountryController
    {

        public CountryController() 
        {
            
        }

        public List<Country> GetAllCountries()
        {

            List<Country> list = new List<Country>();

            foreach (var country in Constants.Counties)
            {
                HtmlWeb web = new HtmlWeb();
                HtmlDocument document = new HtmlDocument();
                

                string abbreviation = country.Key;
                var name = country.Value;

                string url = Constants.BASE_URL_DETAILS + country.Value;

                document: web.Load(url);

                //var temp = document.DocumentNode.OuterHtml;

                // GlobalFirePower has human verification and that blocks the Web Scraping

                try
                {
                    Country newCountry = new Country()
                    {
                        Name = Helpers.ConvertURLNameToCountryName(name)
                    };

                    newCountry.PurchasingPowerParity = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.PURCHASING_POWER_PARITY_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).XPath;

                    newCountry.ForeignExchange = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.FOREIGN_EXCHANGE_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.DefenseBudget = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.DEFENSE_BUDGET_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.ExternalDebt = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.EXTERNAL_DEBT_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.SquareLandArea = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.SQUARE_LAND_AREA_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.CoastlineCoverage = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.COASTLINE_COVERAGE_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.SharedBorders = document.DocumentNode.SelectSingleNode(
                        Constants.PARENT_ELEMENT_TITLE +
                            Constants.SHARED_BORDERS_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.Waterways = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.WATERWAYS_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.TotalPopulation = document.DocumentNode.SelectSingleNode(
                        Constants.PARENT_ELEMENT_TITLE +
                            Constants.TOTAL_POPULATION_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.AvailableManpower = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.AVAILABLE_MANPOWER_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.FitForService = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.FIT_FOR_SERVICE_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.ReachingMilitaryAgeAnually = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.REACHING_MILITARY_AGE_ANUALLY_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.TotalMilitaryPersonnel = document.DocumentNode.SelectSingleNode(
                        Constants.PARENT_ELEMENT_TEXT +
                            Constants.TOTAL_MILITARY_PERSONNEL_TEXT +
                            Constants.CHILD_VALUE_FROM_TEXT).InnerHtml;

                    newCountry.ActivePersonnel = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.ACTIVE_PERSONNEL_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.ReservePersonnel = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.RESERVE_PERSONNEL_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.Paramilitary = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.PARAMILITARY_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.AirforcePersonnel = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TEXT +
                            Constants.AIR_FORCE_PERSONNEL_TEXT +
                            Constants.CHILD_VALUE_FROM_TEXT).InnerHtml;

                    newCountry.ArmyPersonnel = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TEXT +
                            Constants.ARMY_PERSONNEL_TEXT +
                            Constants.CHILD_VALUE_FROM_TEXT).InnerHtml;

                    newCountry.NavyPersonnel = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TEXT +
                            Constants.NAVY_PERSONNEL_TEXT +
                            Constants.CHILD_VALUE_FROM_TEXT).InnerHtml;

                    newCountry.TotalAircraft = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.TOTAL_AIRCRAFT_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.Fighters = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.FIGHTERS_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.AttackTypes = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.ATTACK_TYPES_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.Transports = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.TRANSPORTS_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.Trainers = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.TRAINERS_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.SpecialMission = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.SPECIAL_MISSION_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.TankerFleet = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.TANKER_FLEET_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.Helicopters = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.HELICOPTERS_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.AttackHelicopters = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.ATTACK_HELICOPTERS_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.Tanks = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.TANKS_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.Vehicles = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.VEHICLES_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.SelfPropelledArtillery = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.SELF_PROPELLED_ARTILLERY_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.TowedArtillery = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.TOWED_ARTILLERY_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.RocketArtillery = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.ROCKET_ARTILLERY_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.TotalNavy = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.TOTAL_NAVY_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.AircraftCariiers = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.AIRCRAFT_CARRIERS_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.HelicopterCarriers = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.HELICOPTER_CARRIERS_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.Destroyers = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.DESTROYERS_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.Frigates = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.FRIGATES_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.Corvettes = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.CORVETTES_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.Submarines = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.SUBMARINES_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.PatrolVessels = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.PATROL_VESSELS_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.MineWarfare = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.MINE_WARFARE_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.OilProduction = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.OIL_PRODUCTION_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.OilConsumption = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.OIL_CONSUMPTION_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.OilDeficit = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TEXT +
                            Constants.OIL_DEFICIT_TEXT +
                            Constants.CHILD_VALUE_FROM_TEXT).InnerHtml;

                    newCountry.OilReserves = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.OIL_RESERVES_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.NaturalGasProduction = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.NATURAL_GAS_PRODUCTION_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.NaturalGasConsumption = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.NARUTAL_GAS_CONSUMPTION_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.NaturalGasDeficit = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TEXT +
                            Constants.NATURAL_GAS_DEFICIT_TEXT +
                            Constants.CHILD_VALUE_FROM_TEXT).InnerHtml;

                    newCountry.NaturalGasReserves = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.NATURAL_GAS_RESERVES_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.CoalProduction = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.COAL_PRODUCTION_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.CoalConsumption = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.COAL_CONSUMPTION_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.CoalDeficit = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TEXT +
                            Constants.COAL_DEFICIT_TEXT +
                            Constants.CHILD_VALUE_FROM_TEXT).InnerHtml;

                    newCountry.CoalReserves = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.COAL_RESERVES_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.LaborForce = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.LABOR_FORCE_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.MerchantMarineFleet = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.MERCHANT_MARINE_FLEET_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.Ports = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.PORTS_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.Airports = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.AIRPORTS_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.RoadwayCoverage = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.ROADWAY_COVERAGE_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    newCountry.RailwayCoverage = document.DocumentNode.SelectSingleNode(
                            Constants.PARENT_ELEMENT_TITLE +
                            Constants.RAILWAY_COVERAGE_TITLE +
                            Constants.CHILD_VALUE_FROM_TITLE).InnerHtml;

                    

                    list.Add(newCountry);
                }
                catch (Exception e)
                {
                    ;
                    throw;
                }
                
            }

            return list;
        }
    }
}
