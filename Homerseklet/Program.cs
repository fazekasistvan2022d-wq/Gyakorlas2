using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homerseklet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HomersekletAtvalto homer1 = new HomersekletAtvalto();
            homer1.Celsius = 28;

            Console.WriteLine(homer1.ToFahrenheit()+" Példányosított");
            Console.WriteLine(HomersekletAtvalto.CelsiusToFahrenheit(28)+" Static");
        }
    }
}
