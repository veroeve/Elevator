using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    public class Elevators : IElevator
    {
        Cabin cabin = new Cabin();
        ManeuverControl ManeuverControl = new ManeuverControl();
        CabinKeypad keypad = new CabinKeypad();
        Motor motor = new Motor();
        public object Use(int floor)
        {
            
            keypad.AddButton(10);
           foreach(var item in keypad.ListButton)
            {
                if (item.Number==floor)
                {
                    ManeuverControl= item.Request(floor);
                    
                }
            }

            cabin.Floor = floor;
            return ManeuverControl;
        }
    }
}
