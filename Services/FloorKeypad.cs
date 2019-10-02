using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Enums;

namespace Services
{
    public class FloorKeypad:IFloorKeypad
    {
        string direction;
        List<IButton> listButton = new List<IButton>();
        public void AddButton(string FloorType)
        {
            int number = 1;
            if(FloorType==FloorNumber.middle.ToString())
            {
                number = 2;
                this.direction = Direction.both.ToString();
            }
            if (FloorType == FloorNumber.first.ToString())
            {
                this.direction = Direction.up.ToString();
            }
            if (FloorType == FloorNumber.last.ToString())
            {
                this.direction = Direction.down.ToString();
            }
            int count = 0;
            while (count < number)
            {               
                Button button = new Button(count);
                listButton.Add(button);
            }


        }
    }
}
