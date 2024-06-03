using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_9._1___Intro_inheritance
{
    internal class Radio : ElectricalDevice
    {
        // Her nedarves variabler fra ElictricalDevice
        

        // Constructor + POLYMORFI - base class har i forvejen constructor der initializere variabler
        // der genbruger vi dents funktionalitet oginitializere variabler gennem den
        // med vha. : base()
        public Radio(bool isOn, string brand) : base(isOn,brand) { }

        public void ListenRadio()
        {
            if (IsOn) 
            {
                Console.WriteLine("Listening to radio");
            } else
            {
                Console.WriteLine("Radio switched ogff, need to switch radio on again");
            }
        }
    }
}
