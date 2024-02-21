using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClassLibrary.Products
{
    public class ThermalPaste : ProductClass
    {
        public int ThermalConductivity { get; set; }
        public int MinTemp {  get; set; }
        public int MaxTemp { get; set; }
    }
}
