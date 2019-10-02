using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    public class Context
    {
        private IElevator iElevator;
        public Context()
        { }
        public Context(IElevator iElevator)
        {
            this.iElevator = iElevator;
        }
        public void SetElevator(IElevator iElevator)
        {
            this.iElevator = iElevator;
        }
        public object UseElevator(int floor)
        {
            return(iElevator.Use(floor));
        }
    }
}
