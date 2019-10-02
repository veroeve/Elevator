using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Maneuver
    {
        string process;
        int destinationFloor;

        public int DestinationFloor
        {
            get { return destinationFloor; }
            set { destinationFloor = value; }
        }
        public string Process
        {
            get { return process; }
            set { process = value; }
        }

        public Maneuver(string process,int destinationFloor)
        {
            this.process = process;
            this.destinationFloor = destinationFloor;
        }
    }
}
