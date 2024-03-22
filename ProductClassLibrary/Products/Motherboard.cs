using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClassLibrary.Products
{
    public class Motherboard : ProductClass
    {
        public string Socket {  get; set; }
        public int MaxMemory { get; set; }
        public int MaxMemorySlots { get; set; }
        public string MemoryType { get; set; }
        public string AudioPorts { get; set; }
        public double LANInterface {  get; set; }
        public string Connections { get; set; }
    }
}
