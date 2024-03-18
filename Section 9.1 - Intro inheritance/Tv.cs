using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_9._1___Intro_inheritance
{
    public class Tv : ElectricalDevice
    {
        
        public Tv(bool isOn, string brand) : base(isOn, brand) { }

        public void WatchTv()
        {
            if (IsOn)
            {
                Console.WriteLine("We're watching TV");
            } else
            {
                Console.WriteLine("The TV it off, turn it on to watch");
            }
        }
    }
}
