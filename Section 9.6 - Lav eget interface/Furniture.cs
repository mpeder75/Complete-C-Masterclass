using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_9._6___Lav_eget_interface
{
    internal class Furniture
    {
        public string Color { get; set; }
        public string Material { get; set; }

        public Furniture()
        {
            Color = "White";
            Material = "Wood";
        }  
        
        public Furniture(string color, string material)
        {
            this.Material = material;
            this.Color = color;
        }
    }
}
