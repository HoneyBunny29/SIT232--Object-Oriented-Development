namespace SimpleReactionMachine
{
    public interface IGui
    {
        //gui to controller connected 
        //(This method will be invoked before any other methods)
        void Connect(IController controller);

        //Initialise the gui
        void Init();

        //Called to change the displayed text
        void SetDisplay(string s);
    }
}
