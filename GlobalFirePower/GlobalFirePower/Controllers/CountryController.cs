using GlobalFirePower.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalFirePower.Controllers
{
    public class CountryController
    {
        public CountryController() 
        {
            
        }

        public List<Country> GetAllCountryes()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = new HtmlDocument();
            document = web.Load(Constants.BASE_URL_SITE);

            List<Country> list = new List<Country>();

            return list;
        }
    }
}
