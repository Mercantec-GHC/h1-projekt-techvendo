using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClassLibrary.Products
{
    public class RandomAccessMemory : ProductClass
    {
        public int Capacity { get; set; }
        public string Type { get; set; }
        public int Speed { get; set; }
    }
}
