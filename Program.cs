using System;
using System.Collections.Generic;
using System.Globalization;

namespace TestEngines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int I = 10;
            double Toverheat = 100;
            double Tstart = ReadFromConsole();
            double Hm = 0.01;
            double Hv = 0.0001;
            double C = 0.1;
            List<int> M = new List<int>() { 20, 75, 100, 105, 75, 0 };
            List<int> V = new List<int>() { 0, 75, 150, 200, 250, 300 };

            IEngine firstEngine = new FirstEngine(I, Toverheat, Hm, Hv, C, M, V);

            StandForHeat standForHeat = new StandForHeat(firstEngine);
            StandForPower standForPower = new StandForPower(firstEngine);

            double t = standForHeat.MainTestForHeat(Tstart);
            double maxPower = standForPower.MainTestForPower(Tstart);
        }

        static double ReadFromConsole()
        {
          
            double value = 0.0;
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };
            Console.WriteLine(">> Enter the value of environmental temperature");

            try
            {
                value = Convert.ToDouble(Console.ReadLine(), numberFormatInfo);
            }
            catch
            {
                value = 25.0;
                Console.WriteLine(">> You've entered wrong value...");
            }
            
            return value;

        }
    }
}
