using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClassLibrary.Products
{
    public class GraphicsProcessingUnit : ProductClass
    {
        public int VRAM { get; set; }
        public int CoreClock { get; set; }
        public string MaxResolution { get; set; }
        public string Ports {  get; set; }
        public string Size { get; set; }
        public string Bus { get; set; }
    }
}
