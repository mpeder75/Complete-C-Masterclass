using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_9._6___Lav_eget_interface
{
    internal class Vehicle
    {
        public float Speed { get; set; }
        public string Color { get; set; }


        public Vehicle()
        {
            Speed = 120f;
            Color = "White";
        }

        public Vehicle(float speed, string color)
        {
            this.Speed = speed;
            this.Color = color;
        }
    }
}
