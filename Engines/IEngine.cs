using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEngines
{
    internal interface IEngine
    {
        public int I { get; set; }
        public double Toverheat { get; set; }
        public double Hm { get; set; }
        public double Hv { get; set; }
        public double C { get; set; }
        public List<int> M { get; set; }
        public List<int> V { get; set; }
    }
}
