using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CabinDoor: IDoor 
    {
        string state;
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
