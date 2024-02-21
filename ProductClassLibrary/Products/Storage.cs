using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClassLibrary.Products
{
    public class Storage : ProductClass
    {
        public string StorageType { get; set; }
        public int Capacity { get; set; }
        public string Interface {  get; set; }
        public string Size { get; set; }
        public int WriteSpeed { get; set; }
        public int ReadSpeed { get; set; }
    }
}
