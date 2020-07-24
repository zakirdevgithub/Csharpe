using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> countries = new List<string>()
            {
                "America","Australia","Canada","Bangladesh","India","Pakistan",
                "Latvia","Srilanka","Nepal","Bhutan","Keniya","Brazil","Egypt",
                "Libia","Kazakistan","Turkey","Italy","Spain","China","England",
                "France","Denmark","Uganda","Africa","Alzeria","Nizeria","Hongkong",
                "Thailand","Kuwait","Saudi Arabia","Dubai"
            };

            Console.WriteLine(countries.Count);
            countries.Add("Bhutan");
            countries.Add("Afganisthan");
            Console.WriteLine(countries.Count);
            Console.WriteLine(countries[2]);
            for(int i=0; i<countries.Count(); i++)
            {
                Console.WriteLine(countries[i]);
            }
        }
    }
}
