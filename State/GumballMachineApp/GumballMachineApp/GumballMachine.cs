using System;
using GumballMachineApp.States;

namespace GumballMachineApp
{
    public class GumballMachine
    {
        public GumballMachine(int ballCount)
        {
            SoldOutState = new SoldOutState(this);
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);
            BallCount = ballCount;
            if (ballCount > 0)
            {
                State = NoQuarterState;
            }
        }

        public void InsertQuarter()
        {
            State.InsertQuarter();
        }

        public void EjectQuarter()
        {
            State.EjectQuarter();
        }

        public void TurnCrank()
        {
            State.TurnCrank();
        }

        public void Dispense()
        {
            State.Dispense();
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (BallCount != 0)
            {
                BallCount--;
            }
        }

        public int BallCount { get; private set; }
        
        public IState SoldOutState { get; }

        public IState NoQuarterState { get; }

        public IState HasQuarterState { get; }

        public IState SoldState { get; }

        public IState State { get; set; }
    }
}