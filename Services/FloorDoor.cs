using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class FloorDoor: IFloorDoor
    {
        string state;
        public string Lock()
        {
            string state = "Lock";
            return state;
        }
        public string Unlock()
        {
            string state = "Unlock";
            return state;
        }
        public string Open()
        {
            string state = "Open";
            return state;
        }
        public string Close()
        {
            string state = "Close";
            return state;
        }
    }
}
