using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Services;
using Services.Enums;

namespace Elevator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ManeuverControl maneuverControl = new ManeuverControl();
        public MainWindow()
        {
            InitializeComponent();
            int count = 0;
            while(count<10)
            {
                floors.Items.Add(count);
                count++;
            }
            txtStatus.AppendText($"start-> cabin in floor: 0 \r\n");
        }       
        public void ButtonFloorControl(int NumberFloor)
        {
            if (NumberFloor==0)
            {
                btnUp.Visibility = Visibility.Visible;
                btnDown.Visibility = Visibility.Hidden;
             
            }
            else if (NumberFloor == 9)
            {
                btnUp.Visibility = Visibility.Hidden;
                btnDown.Visibility = Visibility.Visible;
            }
            else
            {
                btnUp.Visibility = Visibility.Visible;
                btnDown.Visibility = Visibility.Visible;
            }

        }
        public string DetectFloor(int numberFloor)
        {
            string floorType;
            if (numberFloor == 0)
            {
                floorType = FloorNumber.first.ToString();
            }
            else if (numberFloor == 9)
            {
                floorType = FloorNumber.last.ToString();
            }
            else
            {
                floorType = FloorNumber.middle.ToString();
            }
            return floorType;
        }
        private void btnDown_Click(object sender, RoutedEventArgs e)
        {
            string floorType;
            int numberFloor = Convert.ToInt32(floors.SelectedValue.ToString());
            floorType = DetectFloor(numberFloor);
            txtStatus.AppendText($"Floor {numberFloor} request cabin \r\n");
            Floor floor = new Floor(numberFloor, floorType);
            if(floor.RequestCabin(numberFloor, Process.down.ToString(),ref maneuverControl))
            {
                txtStatus.AppendText($"Cabin going {Process.down.ToString()} \r\n");
            }
            else
            {
                txtStatus.AppendText($"Rejected request,cabin going {Process.up.ToString()} \r\n");
            }           
        }
        private void btnUp_Click(object sender, RoutedEventArgs e)
        {
            string floorType;
            int numberFloor = Convert.ToInt32(floors.SelectedValue.ToString());
            floorType = DetectFloor(numberFloor);
            txtStatus.AppendText($"Floor {numberFloor} request cabin \r\n");
            Floor floor = new Floor(numberFloor, floorType);
            if (floor.RequestCabin(numberFloor, Process.up.ToString(),ref maneuverControl))
            {
                txtStatus.AppendText($"Cabin going {Process.up.ToString()} \r\n");
            }
            else
            {
                txtStatus.AppendText($"Rejected request,cabin going {Process.down.ToString()} \r\n");
            }

        }

        private void btnFloor0_Click(object sender, RoutedEventArgs e)
        {
            Cabin cabin = new Cabin();
            if (cabin.Request(0, ref maneuverControl))
            {
                txtStatus.AppendText($"Cabin going {maneuverControl.Process} \r\n");
                btnFloor0.Background = Brushes.Red;
            }
            else
            {
                txtStatus.AppendText($"Rejected request,cabin going {maneuverControl.Process} \r\n");
            }
        }

        private void btnFloor1_Click(object sender, RoutedEventArgs e)
        {
            Cabin cabin = new Cabin();
            if (cabin.Request(1, ref maneuverControl))
            {
                txtStatus.AppendText($"Cabin going {maneuverControl.Process} \r\n");
                btnFloor1.Background = Brushes.Red;
            }
            else
            {
                txtStatus.AppendText($"Rejected request,cabin going {maneuverControl.Process} \r\n");
            }
        }

        private void btnFloor2_Click(object sender, RoutedEventArgs e)
        {
            Cabin cabin = new Cabin();
            if (cabin.Request(2, ref maneuverControl))
            {
                txtStatus.AppendText($"Cabin going {maneuverControl.Process} \r\n");
                btnFloor2.Background = Brushes.Red;
            }
            else
            {
                txtStatus.AppendText($"Rejected request,cabin going {maneuverControl.Process} \r\n");
            }
        }

        private void btnFloor3_Click(object sender, RoutedEventArgs e)
        {
            Cabin cabin = new Cabin();
            if (cabin.Request(3, ref maneuverControl))
            {
                txtStatus.AppendText($"Cabin going {maneuverControl.Process} \r\n");
                btnFloor3.Background = Brushes.Red;
            }
            else
            {
                txtStatus.AppendText($"Rejected request,cabin going {maneuverControl.Process} \r\n");
            }
        }

        private void btnFloor4_Click(object sender, RoutedEventArgs e)
        {
            Cabin cabin = new Cabin();
            if (cabin.Request(4, ref maneuverControl))
            {
                txtStatus.AppendText($"Cabin going {maneuverControl.Process} \r\n");
                btnFloor4.Background = Brushes.Red;
            }
            else
            {
                txtStatus.AppendText($"Rejected request,cabin going {maneuverControl.Process} \r\n");
            }
        }

        private void btnFloor5_Click(object sender, RoutedEventArgs e)
        {
            Cabin cabin = new Cabin();
            if (cabin.Request(5, ref maneuverControl))
            {
                txtStatus.AppendText($"Cabin going {maneuverControl.Process} \r\n");
                btnFloor5.Background = Brushes.Red;
            }
            else
            {
                txtStatus.AppendText($"Rejected request,cabin going {maneuverControl.Process} \r\n");
            }
        }
        private void btnFloor6_Click(object sender, RoutedEventArgs e)
        {
            Cabin cabin = new Cabin();
            if (cabin.Request(6, ref maneuverControl))
            {
                txtStatus.AppendText($"Cabin going {maneuverControl.Process} \r\n");
                btnFloor6.Background = Brushes.Red;
            }
            else
            {
                txtStatus.AppendText($"Rejected request,cabin going {maneuverControl.Process} \r\n");
            }
            //var bc = new BrushConverter();
            //btnFloor8.Background = (Brush)bc.ConvertFrom("#FFDDDDDD");
        }
        private void btnFloor7_Click(object sender, RoutedEventArgs e)
        {
            Cabin cabin = new Cabin();
            if (cabin.Request(7, ref maneuverControl))
            {
                txtStatus.AppendText($"Cabin going {maneuverControl.Process} \r\n");
                btnFloor7.Background = Brushes.Red;
            }
            else
            {
                txtStatus.AppendText($"Rejected request,cabin going {maneuverControl.Process} \r\n");
            }
        }
        private void btnFloor8_Click(object sender, RoutedEventArgs e)
        {
            Cabin cabin = new Cabin();
            if (cabin.Request(8, ref maneuverControl))
            {
                txtStatus.AppendText($"Cabin going {maneuverControl.Process} \r\n");
                btnFloor8.Background = Brushes.Red;
            }
            else
            {
                txtStatus.AppendText($"Rejected request,cabin going {maneuverControl.Process} \r\n");
            }
        }

        private void btnFloor9_Click(object sender, RoutedEventArgs e)
        {
            Cabin cabin = new Cabin();
            if (cabin.Request(8, ref maneuverControl))
            {
                txtStatus.AppendText($"Cabin going {maneuverControl.Process} \r\n");
                btnFloor8.Background = Brushes.Red;
            }
            else
            {
                txtStatus.AppendText($"Rejected request,cabin going {maneuverControl.Process} \r\n");
            }
        }

        
    }
}
