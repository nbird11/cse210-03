using System;
using System.Collections.Generic;

namespace Game
{
    /// Director keeps track of the game loop, and the guessed letters, updates the "___l_"
    public class Director
    {
        // Attributes
        private bool _isPlaying = true;
        private Parachute _parachute = new Parachute();
        private TerminalService _terminal = new TerminalService();
        private Dictionary _dictionary = new Dictionary();

        private List<char> _displayWord = new List<char>();

        private List<char> _guesses = new List<char>();

        // Constructor
        public Director()
        {
            foreach (char letter in _dictionary.getWord())
            {
                _displayWord.Add('_');
            }
        }

        // Methods
        // Game loop
        public void startGame()
        {
            do
            {
                // _parachute.getParachute();
                compareLetter(_terminal.ReadInput());

            } while (_isPlaying);
        }

        private bool compareLetter(char letter)
        {
            foreach (char character in _guesses)
            {
                if (letter == character)
                {
                    
                }
            }

            bool correctGuess = false;
            foreach (char character in _dictionary.getWord())
            {
                if (letter == character)
                {
                    correctGuess = true;
                }
            }
            return correctGuess;
        }

        private void outputDisplayedWord()
        {

        }
    }
}