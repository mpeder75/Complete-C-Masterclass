using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_9._6___Lav_eget_interface
{
    internal class Chair : Furniture, IDestroyable
    {
        public string DestructionSound { get; set; }

        public Chair(string color, string material)
        {
            this.Color = color;
            this.Material = material;     
            DestructionSound = "ChairDestructionSound.mp3";
        }             

        public void Destroy()
        {
            Console.WriteLine($"The Color {Color} chair was destroyed");
            Console.WriteLine($"Playing destruction sound {DestructionSound}");
            Console.WriteLine("Spawning chari parts");
        }
    }
}
