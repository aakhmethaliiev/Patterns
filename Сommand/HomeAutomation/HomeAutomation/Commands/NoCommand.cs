namespace HomeAutomation.Commands
{
    public class NoCommand : ICommand
    {
        public void Execute()
        {
            throw new System.NotImplementedException();
        }

        public void Undo()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return "Button doesn't assigned";
        }
    }
}