using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Motor:IMotor 
    {
        string state;
        public string Stop()
        {
            state = "stop";
            return state;
        }
        public string Ascend()
        {
            state = "Ascend";
            return state;
        }
        public string Descend()
        {
            state = "Descend";
            return state;
        }
    }
}
