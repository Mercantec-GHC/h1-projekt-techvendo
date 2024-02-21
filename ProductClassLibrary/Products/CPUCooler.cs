using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClassLibrary.Products
{
    public class CPUCooler : ProductClass
    {
        public string Type { get; set; }
        public string Socket { get; set; }
        public string Heatsink { get; set; }
        public int Noise { get; set; } // in Decibals, dB
        public int RPM { get; set; }
        public string Size { get; set; }
    }
}
