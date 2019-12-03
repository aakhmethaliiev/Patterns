using HomeAutomation.Controls;

namespace HomeAutomation.Commands
{
    public class GarageDoorOpenCommand : ICommand
    {
        private readonly GarageDoor _garageDoor;

        public GarageDoorOpenCommand(GarageDoor command)
        {
            _garageDoor = command;
        }

        public void Execute()
        {
            _garageDoor.Up();
        }

        public void Undo()
        {
            _garageDoor.Down();
        }

        public override string ToString()
        {
            return "Garage door open";
        }
    }
}