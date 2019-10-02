using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CabinKeypad : ICabinKeypad
    {
        int numberButtons;

        List<Button> listButton = new List<Button>();
        public List<Button> ListButton
        {
            get { return listButton; }
        }
        public void AddButton(int numberButtons)
        {
            this.numberButtons = numberButtons;
            int count = 0;
            while(count< this.numberButtons)
            {
                Button button = new Button(count);
                listButton.Add(button);
                count++;
            }

        }
    }
}
