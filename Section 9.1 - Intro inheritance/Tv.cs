using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_9._1___Intro_inheritance
{
    internal class Tv : ElectricalDevice
    {
        public Tv(bool isOn, string brand) : base(isOn, brand) { }

        public void WatchTv()
        {
            if (IsOn)
            {
                Console.WriteLine("Watching tc");
            }
            else
            {
                Console.WriteLine("Tv switched ff, need to switch tv on again");
            }
        }
    }
}
