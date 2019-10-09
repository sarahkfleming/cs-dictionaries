using System;
using System.Collections.Generic;

namespace RandallCarLot
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Dictionary<string, Dictionary<string, string>>> vehicles = new List<Dictionary<string, Dictionary<string, string>>>();

            Dictionary<string, Dictionary<string, string>> vehicle1 = new Dictionary<string, Dictionary<string, string>>();

            vehicle1.Add("vehicle", new Dictionary<string, string>(){
            {"year", "2008"},
            {"model", "Damfresh"},
            {"make", "Biotraxquote"},
            {"color", "sky magenta"},
        });
            vehicle1.Add("salesAgent", new Dictionary<string, string>(){
            {"mobile", "(896) 478-6975"},
            {"lastName", "Botsford"},
            {"firstName", "Shaina"},
        });
            vehicle1.Add("credit", new Dictionary<string, string>(){
            {"creditProvider", "J.P.Morgan Chase & Co"},
            {"account", "601109582720302"},
        });

            Dictionary<string, Dictionary<string, string>> vehicle2 = new Dictionary<string, Dictionary<string, string>>();

            vehicle2.Add("vehicle", new Dictionary<string, string>(){
            {"year", "2010"},
            {"model", "Hotquadtrax"},
            {"make", "Transtintechno"},
            {"color", "robin egg blue"},
        });
            vehicle2.Add("salesAgent", new Dictionary<string, string>(){
            {"mobile", "562.300.2912"},
            {"lastName", "Davis"},
            {"firstName", "Gerardo"},
        });
            vehicle2.Add("credit", new Dictionary<string, string>(){
            {"creditProvider", "PNC Financial Services"},
            {"account", "34578280562836"},
        });

            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);

            foreach (Dictionary<string, Dictionary<string, string>> vehicle in vehicles)
            {
                Console.WriteLine("-------------");
                Console.WriteLine("Vehicle");
                Console.WriteLine("-------------");
                Console.WriteLine();

                foreach (KeyValuePair<string, Dictionary<string, string>> vehicleInfo in vehicle)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{vehicleInfo.Key}");
                    Console.WriteLine("-------------");
                    foreach (KeyValuePair<string, string> details in vehicleInfo.Value)
                    {
                        Console.Write($"{details.Key}: ");
                        Console.WriteLine($"{details.Value}");
                    }
                }
            }
        }
    }
}
