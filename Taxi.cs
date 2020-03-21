using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxiapp
{
    class Taxi
    {
        public string DriverName;
        public bool OnDuty;
        public int NumPassenger;
        string status;

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : " + DriverName);
            if (OnDuty == true)
            {
                status = "Yes";
            }
            else
            {
                status = "No";
            }
            Console.WriteLine("On Duty : " + status);
            Console.WriteLine("Number of Passenger : " + NumPassenger);
        }

        public void PickUpPassenger()
        {
            Console.WriteLine(DriverName + " sedang menjemput penumpang");
        }
        public void DropOffPassenger()
        {
            Console.WriteLine(DriverName + " selesai mengantar penumpamg");
        }
    }
}
