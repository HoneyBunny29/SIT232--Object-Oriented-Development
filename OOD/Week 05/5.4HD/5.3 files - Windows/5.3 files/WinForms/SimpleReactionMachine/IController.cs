using System;

namespace SimpleReactionMachine
{
    public interface IController
    {
        //gui to controller connected 
        //(This method will be invoked before any other methods)
        void Connect(IGui gui, IRandom rng);

        //Requested the controller to be initialized.
        void Init();

        //Sounded each time a coin is placed into the device.
        void CoinInserted();

        //Sounded anytime the stop or go button is touched.
        void GoStopPressed();

        //Asked to give the controller a TICK
        void Tick();
    }
}
