using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    internal class CountryView
    {
        public Country DisplayCountry { get; set; }

        public CountryView (Country _country)
        {
            DisplayCountry = _country;
        }
        
        public void Display()
        {
            Console.WriteLine($"Name: {DisplayCountry.Name}  Continent:{DisplayCountry.Continent}  ");
            foreach (string s in DisplayCountry.Colors)
            {
                Console.WriteLine($"Color:{s}");
            }
        }
    }


}
