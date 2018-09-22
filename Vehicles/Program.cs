using System;

namespace Vehicles
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("Journey by airplane");
            Airplane myPlane = new Airplane();
            myPlane.StartEngine("Contact");
            myPlane.TakeOff();
            myPlane.Drive();
            myPlane.Land();
            myPlane.StopEngine("Phut phut");
            Console.WriteLine("\nJourney by car:");
            Car mycar = new Car();
            mycar.StartEngine("Brm brm");
            mycar.Accelerate();
            mycar.Drive();
            mycar.Brake();
            mycar.StopEngine("Phut phut");
            Console.WriteLine("\nTesting polymorphism");
            Vehicle v = mycar;
            v.Drive();
            v = myPlane;
            v.Drive();
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
