﻿namespace GumballMachineApp.States
{
    public class SoldState : IState
    {
        private GumballMachine _gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            throw new System.NotImplementedException();
        }

        public void EjectQuarter()
        {
            throw new System.NotImplementedException();
        }

        public void TurnCrank()
        {
            throw new System.NotImplementedException();
        }

        public void Dispense()
        {
            throw new System.NotImplementedException();
        }
    }
}