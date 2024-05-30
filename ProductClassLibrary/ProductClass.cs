using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClassLibrary
{
    public class ProductClass : ProductParent
    {
        public double Price { get; set; }
        public string EANNumber { get; set; }
        public string Title { get; set; } = string.Empty;
        public int ProductID { get; set; }
        public int SellerID { get; set; }
        public string Description { get; set; } = string.Empty;
        public int VRAM { get; set; }
        public string Ports { get; set; }
        public int Cores { get; set; }
        public int Threads { get; set; }
        public int Capacity { get; set; }
        public int RamSpeed { get; set; }

    }
}
