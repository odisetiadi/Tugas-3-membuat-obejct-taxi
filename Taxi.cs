using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_membuat_object_taxi_3
{
    class Taxi
    {
        public string DriverName;
        public Boolean OnDuty;
        public float NumPassenger;

        public void taxiinfo()
        {
            Console.WriteLine("Driver name: {0}", DriverName);
            Console.WriteLine("On Duty: {0}", OnDuty);
            Console.WriteLine("Number Of Passenger: {0}", NumPassenger);
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("\n{0} sedang menjemput penumpang", DriverName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
        }
    }
}
