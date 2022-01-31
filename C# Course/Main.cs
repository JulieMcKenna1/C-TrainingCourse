using System;

namespace C__Course
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld hello = new HelloWorld();
            hello.HelloWorldPrint();
            Challenge challenge = new Challenge();
            //challenge.Survery(); // can then have them pass the arguments in through this
            Challenge2 challenge2 = new Challenge2();
            //challenge2.Passcode();
            ForLoop forLoop = new ForLoop();
            //forLoop.ForLoopPractice();
            Challenge3 challenge3 = new Challenge3();
            //challenge3.LoopCounting();
            SchoolTracker schoolTracker = new SchoolTracker();
            //schoolTracker.SchoolTracking();
            JobCanidate job = new JobCanidate();
            //job.Swicth();
            Final final = new Final();
            final.SensorSetup("Vista", "10.13.204.31", 10, "30N ZF 33928E 00025N", 8009, 10);
            final.SensorSetup("Axis 22", "10.13.196.22", 15, "28N ZF 33928E 00015N", 0, 0);
        }
    }
}
