using HomeAutomation.Controls;

namespace HomeAutomation.Commands
{
    public class GarageDoorCloseCommand : ICommand
    {
        private readonly GarageDoor _garageDoor;

        public GarageDoorCloseCommand(GarageDoor command)
        {
            _garageDoor = command;
        }

        public void Execute()
        {
            _garageDoor.Down();
        }

        public void Undo()
        {
            _garageDoor.Up();
        }

        public override string ToString()
        {
            return "Garage door close";
        }
    }
}