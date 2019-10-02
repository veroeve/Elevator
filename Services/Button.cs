using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Button:IButton 
    {
        int number;
        ManeuverControl maneuver;
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public Button(int number)
        {
            this.number = number;
        }
        public ManeuverControl Request(int number)
        {
           return maneuver = new ManeuverControl(number);
        }
    }
}
