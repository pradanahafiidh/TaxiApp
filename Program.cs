using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxiapp
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat object Taxi
            Taxi taxi = new Taxi();

            //pengaturan nilai properties
            taxi.DriverName = "Hafidh";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            //pemanggilan method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
