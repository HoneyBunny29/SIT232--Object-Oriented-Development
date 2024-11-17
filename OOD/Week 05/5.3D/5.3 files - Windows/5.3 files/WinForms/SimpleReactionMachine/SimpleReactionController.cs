using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleReactionMachine
{
    internal class SimpleReactionController : IController
    {

        // Game time settings
        private const int MIN_WAIT_TIME = 100;
        // 1 second in ticks is the minimum wait duration.
        private const int MAX_WAIT_TIME = 250;
        // Max wait duration, measured in ticks: 2.5 seconds
        private const int MAX_GAME_TIME = 200;
        // Reaction time in ticks is limited to 2 seconds.
        private const int GAMEOVER_TIME = 300;
        // Show the result in ticks for three seconds.
        private const double TICKS_PER_SECOND = 100.0; // Relative to 10 millisecond ticks

        // Instance variables and properties
        private State _state;
        private IGui Gui { get; set; }
        private IRandom Rng { get; set; }
        private int Ticks { get; set; }  // counter each time controller.Tick() is called 

        /// <summary>
        /// Connects the controller to the Gui and Random Number Generator
        /// </summary>
        /// <param name="gui">IGui concrete implementation</param>
        /// <param name="rng">IRandom concreate implementation</param>
        public void Connect(IGui gui, IRandom rng)
        {
            Gui = gui;
            Rng = rng;
            Init();
        }

        // <summary>
        // Initialises the state of the controller at the start of the program
        // </summary>
        public void Init()
        {
            _state = new OnState(this);
        }

        // <summary>
        // Coin inserted event handler
        // </summary>
        public void CoinInserted()
        {
            _state.CoinInserted();
        }

        // <summary>
        // Go/Stop pressed event handler
        // </summary>
        public void GoStopPressed()
        {
            _state.GoStopPressed();
        }

        // <summary>
        // Tick event handler
        // </summary>
        public void Tick()
        {
            _state.Tick();
        }

        // <summary>
        // Sets the state of the controller to the desired state
        // </summary>
        // <param name="state">The new state to transition to</param>
        private void SetState(State state)
        {
            _state = state;
        }

        // <summary>
        // Base class for concrete State classes
        // </summary>
        private abstract class State
        {
            protected SimpleReactionController _controller;

            public State(SimpleReactionController controller)
            {
                _controller = controller;
            }

            public abstract void CoinInserted();
            public abstract void GoStopPressed();
            public abstract void Tick();
        }

        // <summary>
        // condition of the game while a coin is being entered
        // </summary>
        private class OnState : State
        {
            public OnState(SimpleReactionController controller) : base(controller)
            {
                _controller.Gui.SetDisplay("Insert coin");
            }

            public override void CoinInserted()
            {
                _controller.SetState(new ReadyState(_controller));
            }
            public override void GoStopPressed() { }
            public override void Tick() { }
        }

        // <summary>
        // condition of the game after a coin is put but before it is
        // started
        // </summary>
        private class ReadyState : State
        {
            public ReadyState(SimpleReactionController controller) : base(controller)
            {
                _controller.Gui.SetDisplay("Press Go!");
            }

            public override void CoinInserted() { }
            public override void GoStopPressed()
            {
                _controller.SetState(new WaitState(_controller));
            }
            public override void Tick() { }
        }

        // <summary>
        // condition of the game after it has launched and is awaiting the
        // random time
        // </summary>
        private class WaitState : State
        {
            private int _waitTime;
            public WaitState(SimpleReactionController controller) : base(controller)
            {
                _controller.Gui.SetDisplay("Wait...");
                _controller.Ticks = 0;
                _waitTime = _controller.Rng.GetRandom(MIN_WAIT_TIME, MAX_WAIT_TIME);
            }

            public override void CoinInserted() { }
            public override void GoStopPressed()
            {
                _controller.SetState(new OnState(_controller));
            }
            public override void Tick()
            {
                _controller.Ticks++;
                if (_controller.Ticks == _waitTime)
                {
                    _controller.SetState(new RunningState(_controller));
                }
            }
        }

        // <summary>
        // Situation of the game while the countdown is in progress and the timer is waiting to
        // user to respond by hitting the Stop/Go button
        // </summary>
        private class RunningState : State
        {
            public RunningState(SimpleReactionController controller) : base(controller)
            {
                _controller.Gui.SetDisplay("0.00");
                _controller.Ticks = 0;
            }

            public override void CoinInserted() { }
            public override void GoStopPressed()
            {
                _controller.SetState(new GameOverState(_controller));
            }

            public override void Tick()
            {
                _controller.Ticks++;
                _controller.Gui.SetDisplay(
                    (_controller.Ticks / TICKS_PER_SECOND).ToString("0.00"));
                if (_controller.Ticks == MAX_GAME_TIME)
                {
                    _controller.SetState(new GameOverState(_controller));
                }
            }
        }

        // <summary>
        // Condition of the game after the allotted time has passed, or the user's response.
        // </summary>
        private class GameOverState : State
        {
            public GameOverState(SimpleReactionController controller) : base(controller)
            {
                _controller.Ticks = 0;
            }

            public override void CoinInserted() { }
            public override void GoStopPressed()
            {
                _controller.SetState(new OnState(_controller));
            }
            public override void Tick()
            {
                _controller.Ticks++;
                if (_controller.Ticks == GAMEOVER_TIME)
                {
                    _controller.SetState(new OnState(_controller));
                }
            }
        }
    }
}