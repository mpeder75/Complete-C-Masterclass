using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_9._6___Lav_eget_interface
{
    internal interface IDestroyable
    {
        // prop to store audio file of teh destruction sound
         string DestructionSound { get; set; }

        // method to destroy an object
        void Destroy();
    }
}
