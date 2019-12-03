using System;

namespace HomeAutomation.Commands
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}