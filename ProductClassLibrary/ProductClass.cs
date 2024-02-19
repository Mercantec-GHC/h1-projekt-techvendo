using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClassLibrary
{
    internal class ProductClass : ProductParent
    {
        public double Price { get; set; }
        public string EANNumber { get; set; }

    }
}
