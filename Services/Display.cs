using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Display:IDisplay
    {
        public string ShowFloor(int floorNumber,string proccess)
        {
            string message="";
            
            if(proccess== "ascent")
            {
                message = $"  {floorNumber}  /\\'";

            }
            if (proccess == "descent")
            {
                message = $"  {floorNumber}  \\/'";
            }
            return message;
        }
    }
}
