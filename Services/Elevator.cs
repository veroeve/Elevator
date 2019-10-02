using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Elevator:IElevator
    {
        string state;
        IMotor motor;
        IManeuverControl ManeuverControl;
        Cabin cabin= new Cabin();
        
        public void Use(string state, int floorNumber)
        {

        }
    }
}
