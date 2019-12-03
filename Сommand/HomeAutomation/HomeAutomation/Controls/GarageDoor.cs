using System;

namespace HomeAutomation.Controls
{
    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Garage door is up");
        }

        public void Down()
        {
            Console.WriteLine("Garage door is down");
        }

        public void Stop()
        {
            Console.WriteLine("Garage door is stop");
        }

        public void LightOn()
        {
            Console.WriteLine("Light in garage is on");
        }

        public void LightOff()
        {
            Console.WriteLine("Light in garage is off");
        }
    }
}