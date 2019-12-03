using System;
using HomeAutomation.Commands;
using HomeAutomation.Controls;
using HomeAutomation.RemoteControls;

namespace HomeAutomation
{
    internal class Program
    {
        private static void Main()
        {
            var remote = new RemoteControl();

            var light = new Light();
            var lightOn = new LightOnCommand(light);
            var lightOff = new LightOffCommand(light);

            var garageDoor = new GarageDoor();
            var garageDoorOpen = new GarageDoorOpenCommand(garageDoor);
            var garageDoorClose = new GarageDoorCloseCommand(garageDoor);

            remote.SetCommand(0, lightOn, lightOff);
            remote.SetCommand(1, garageDoorOpen, garageDoorClose);

            Console.WriteLine(remote);

            remote.OnButtonWasPushed(0);
            remote.OffButtonWasPushed(0);
            remote.OnButtonWasPushed(1);
            remote.OffButtonWasPushed(1);

            Console.WriteLine(remote);

            Console.ReadKey();
        }
    }
}