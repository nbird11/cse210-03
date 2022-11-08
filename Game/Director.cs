using System;


namespace Game
{
    /// Director keeps track of the game loop, and the guessed letters, updates the "___l_"
    public class Director
    {
        // Attributes
        private bool _isPlaying = true;
        private Parachute _parachute = new Parachute();
        private TerminalService _terminal = new TerminalService();

        // Constructor
        public Director()
        {}

        // Methods
        // Game loop
        public void startGame()
        {
            do
            {
                // _parachute.getParachute();
                
            } while (_isPlaying);
        }
    }
}