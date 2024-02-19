using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClassLibrary.Products
{
    internal class GraphicsProcessingUnit : ProductClass
    {
        public int VRAM { get; set; }
        public int CoreClock { get; set; }
        public string MaxResolution { get; set; }
        public string Ports {  get; set; }
        public string Sizes { get; set; }
        public string Bus { get; set; }
    }
}
