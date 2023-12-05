using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEngines
{
    internal class FirstEngine : IEngine
    {
        public int I { get; set; }
        public double Toverheat { get; set; }
        public double Hm { get; set; }
        public double Hv { get; set; }
        public double C { get; set; }
        public List<int> M { get; set; }
        public List<int> V { get; set; }

        public FirstEngine(int I, double Toverheat, double Hm, double Hv, double C, List<int> M, List<int> V) 
        {
            this.I = I;
            this.Toverheat = Toverheat;
            this.Hm = Hm;
            this.Hv = Hv;
            this.C = C;
            this.M = M;
            this.V = V;
        }

    }
}
