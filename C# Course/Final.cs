//Final project
using System;

namespace C__Course
{
    class Final
    {
        public void SensorSetup(String Name, String IP, int Alt, String Location, int Port, int RadarID)
        {
            Console.WriteLine("Which type of sesnor are you setting up(Axis or Vista)? a/v ");
            var sensorType = Console.ReadLine();

            switch (sensorType)
            {
                case "a":
                    Console.WriteLine("Setting up an Axis camera");
                    Console.WriteLine("Sensor Name: {0}\n IP: {1}\n Altitude: {2}\n Location: {3}", Name, IP, Alt, Location);
                    Console.WriteLine("Axis Camera has been set up");
                    break;
                case "v":
                    Console.WriteLine("Setting up a Vista");
                    Console.WriteLine("Sensor Name: {0}\n IP: {1}\n Altitude: {2}\n Location: {3}\n Port Number: {4}\n Radar ID: {5}", Name, IP, Alt, Location, Port, RadarID);
                    Console.WriteLine("Vista has been set up");
                    break;                
                default:
                    Console.WriteLine("Not a valid entry");
                    break;
            }
        }
    }
}
