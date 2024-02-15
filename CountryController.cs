using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    internal class CountryController
    {
        List<Country> CountryDB = new List<Country>()
        {
            new Country("Brazil", "South America",new List<string> {"Yellow, Green"}),
            new Country ("France", "Europe",new List<string> {"Red", "Blue", "White" }),
            new Country ("China", "Asia", new List<string> {"Red, Gold" }),
            new Country ("Russia", "Europe", new List<string> {"White, Blue, Red"}), 
            new Country ("Canada", "North America", new List<string> {"Red", "White"})
        };
        public void CountryAction(Country c)
        {
            CountryView view = new CountryView(c);
            view.Display(); 
        }

        public void WelcomeAction()
        {
            while (true)
            {
                CountryListView view = new CountryListView(CountryDB);
                Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
                view.Display();
                Console.WriteLine("Please choose an country");
                int choice = int.Parse(Console.ReadLine());
                CountryAction(CountryDB[choice]);
                Console.WriteLine("Would you like to choose another country. y/n");
                string choice2 = Console.ReadLine().ToLower().Trim();
                if (choice2 == "n")
                {
                    break;
                }
            }
        }
    }
}
