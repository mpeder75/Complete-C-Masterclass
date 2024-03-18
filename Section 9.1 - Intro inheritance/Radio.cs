using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_9._1___Intro_inheritance
{
    // Radio er child class, ElectricalDevice er parent/base class
    class Radio : ElectricalDevice
    {
        // Her nedarves der properties fra base class

        // constructor - nedarver, så proprty settes, IsOn = isON, Brand = brand;
        public Radio(bool isOn, string brand) : base(isOn, brand) { }

        // metoderne SwitchOn & SwitchOff nedarves fra base class

        public void ListenRadio()
        {
            if (IsOn)
            {
                Console.WriteLine("Listening to raDIO");
            }
            else
            {
                Console.WriteLine("Radio is switched off, switch it on first");
            }
        }
    }
}


