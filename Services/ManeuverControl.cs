using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Enums;

namespace Services
{
    public class ManeuverControl:IManeuverControl 
    {
        List<Maneuver> listManeuver = new List<Maneuver>();
        string motorstate;
        string process;
        int currentFloor;
        public int CurrentFloor
        {
            get { return currentFloor; }
            set { currentFloor = value; }
        }
        public string Motorstate
        {
            get { return motorstate; }
            set { motorstate = value; }
        }
        public string Process
        {
            get { return process; }
            set { process = value; }
        }
        public List<Maneuver> ListManeuver
        {
            get { return listManeuver; }
        }

        public ManeuverControl()
        {

        }

        public ManeuverControl(int DestinationFloor)
        {
            if (ListManeuver.Count>0)
            {
                if (listManeuver.First().Process == Process.up.ToString())
                {
                    if (listManeuver.First().DestinationFloor < DestinationFloor)
                    {
                        AscentControl(DestinationFloor);
                    }
                }
                if (listManeuver.First().Process == Process.down.ToString())
                {
                    if (listManeuver.First().DestinationFloor > DestinationFloor)
                    {
                        DescentControl(DestinationFloor);
                    }
                }
            } 
            else
            {
                Cabin cabin = new Cabin();
                currentFloor = cabin.GetFloor();
                if(currentFloor>DestinationFloor)
                {
                    DescentControl(DestinationFloor);
                }
                else
                {
                    AscentControl(DestinationFloor);
                }
            }
             
        }

        public void AscentControl(int DestinationFloor)
        {
            Maneuver Maneuver = new Services.Maneuver(Process.up.ToString(), DestinationFloor);
            listManeuver.Add(Maneuver);
            listManeuver = listManeuver.OrderBy(o => o.DestinationFloor).ToList();
        }
        public void DescentControl(int DestinationFloor)
        {
            Maneuver Maneuver = new Services.Maneuver(Process.down.ToString(), DestinationFloor);
            listManeuver.Add(Maneuver);
            listManeuver = listManeuver.OrderByDescending(o => o.DestinationFloor).ToList();

        }
    }
}
