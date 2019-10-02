using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    interface IFloorDoor:IDoor 
    {
        string Lock();
        string Unlock();
    }
}
