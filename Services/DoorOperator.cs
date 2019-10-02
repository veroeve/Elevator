using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class DoorOperator:IDoorOperator 
    {
        FloorDoor Door;
        public void LockDoor()
        {
            Door.Close();
            Door.Lock();
        }
        public void UnlockDoor()
        {
            Door.Unlock();
            Door.Open();
        }
    }
}
