using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClassLibrary.Products
{
    public class PowerSupply : ProductClass
    {
        public string FormFactor {  get; set; }
        public string PowerCapacity { get; set; }
        public string Connections { get; set; }
        public string Certificate { get; set; }
    }
}
