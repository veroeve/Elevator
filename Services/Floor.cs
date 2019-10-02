using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{

    public class Floor
    {
        int numberFloor;
        string floorType;
        IFloorKeypad keypad;
        IFloorDoor door;

        public Floor(int numberFloor, string floorType)
        {
            this.numberFloor = numberFloor;
            this.floorType = floorType;
        }

        public bool RequestCabin(int numberFloor,string process, ref  ManeuverControl maneuverControl)
        {
            return false;
        }

        private void GetKeypad()
        {

        }
        
    }
}
