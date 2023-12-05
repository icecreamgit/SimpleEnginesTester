using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEngines
{
    internal class StandForHeat
    {
        IEngine engine;
        public StandForHeat(IEngine engine)
        {
            this.engine = engine;
        }

        public double MainTestForHeat(double Tstart)
        {
            double Tengine = Tstart;
            double Tcooling;
            double fullTime = 0.0;
            List<double> t = new List<double>();
            
            for (int i = 0; Tengine < engine.Toverheat; i++)
            {
                t.Add(engine.V[i] * engine.I / engine.M[i]);
                Tengine += (engine.M[i] * engine.Hm + Math.Pow(engine.V[i], 2) * engine.Hv) * t[i];
                Tcooling = engine.C * (Tstart - Tengine);
                Tengine += Tcooling;
                fullTime += t[i];
            }
            return fullTime;
        }

    }
}
