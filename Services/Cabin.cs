using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Cabin
    {
        int amountPeople;
        IDoor door;
        ICabinKeypad keypad;
        IDisplay Display;
        int floor;

        public int AmountPeople
        {
            get { return amountPeople; }
            set { amountPeople = value; }
        }
        public int Floor
        {
            get { return floor; }
            set { floor = value; }
        }

        public bool Request(int numberFloor, ref ManeuverControl maneuverControl)
        {
            return false;
        }

        public int GetFloor()
        {
            return floor;
        }
    }
}
