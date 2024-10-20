using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalFirePower.Controllers
{
    public class Helpers
    {
        public static string ConvertURLNameToCountryName(string URLName)
        {
            string name = "";

            if (URLName.Contains('-'))
            {
                string[] words = URLName.Split('-');

                for (int i = 0; i < words.Length; i++)
                {
                    string convertedWord = words[i][0].ToString().ToUpper() + words[i].Substring(1);
                    words[i] = convertedWord;
                }

                name = string.Join(" ", words);
            }
            else
            {
                name = URLName[0].ToString().ToUpper() + URLName.Substring(1);
            }

            return name;
        }
    }
}
