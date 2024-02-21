using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClassLibrary.Products
{
    public class CentralProcessingUnit : ProductClass
    {
        public string Socket {  get; set; }
        public int Cores { get; set; }
        public int Threads { get; set; }
        public double IdleClockSpeed { get; set; }
        public double MaxClockSpeed { get; set; }
        public int Cache {  get; set; }
    }
}
