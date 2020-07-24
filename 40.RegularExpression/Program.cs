using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\d";
            Regex regex = new Regex(pattern);
            string myText = "this is my mobile number 01789214021";
            MatchCollection matchcoll = regex.Matches(myText);
            Console.WriteLine(matchcoll.Count);
            foreach(Match total in matchcoll)
            {
                GroupCollection group= total.Groups;
                Console.WriteLine("{0} found at {1}\n",group[0].Value, group[0].Index );
            }


        }
    }
}
