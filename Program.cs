using System;

namespace Tugas_membuat_object_taxi_3
{
    class Program
    {
        static void Main(string[] args)
        {
          

                Taxi taxi = new Taxi();

                taxi.DriverName = "Jono";
                taxi.OnDuty = true;
                taxi.NumPassenger = 10;

                taxi.taxiinfo();
                taxi.PickUpPassenger();
                taxi.DropOffPassenger();


                Console.ReadKey();
            }
        }
    }
