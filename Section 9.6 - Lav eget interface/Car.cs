using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_9._6___Lav_eget_interface
{
    internal class Car : Vehicle, IDestroyable
    {
        public string DestructionSound { get; set; }

        public List<IDestroyable> DestroyablesNearby;

        public Car(float speed, string color)
        {
            this.Speed = speed;
            this.Color = color;
            DestructionSound = "CarExplosion.mp3";
            DestroyablesNearby = new List<IDestroyable>();
        }
       

        public void Destroy()
        {
            Console.WriteLine($"Playing desctrution sound {DestructionSound}");
            Console.WriteLine("Create fire");

            foreach (IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }
    }
}
