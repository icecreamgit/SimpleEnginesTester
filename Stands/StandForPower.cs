using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEngines
{
    internal class StandForPower
    {
        IEngine engine;
        public StandForPower(IEngine engine)
        {
            this.engine = engine;
        }
        public double MainTestForPower(double Tstart)
        {
            List<double> N = new List<double>();
            double maxValue = 0.0;

            for (int i = 0; i < (engine.V).Count; i++)
            {
                N.Add(engine.M[i] * engine.V[i] / 1000);
            }
            
            for (int i = 0; i < N.Count; i++)
            {
                if (maxValue < N[i])
                {
                    maxValue = N[i];
                }
            }
            return maxValue;
        }
        
    }
}
