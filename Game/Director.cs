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
        private string _secretWord;
        private List<char> _displayWord = new List<char>();
        private List<char> _guesses = new List<char>();
        private char _guess;

        // Constructor
        public Director()
        {
            _secretWord = _dictionary.getWord();
            foreach (char letter in _secretWord)
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
                _parachute.drawJumper();
                _guess = _terminal.ReadInput();
                // Check if the letter was already guessed
                while (_guesses.Contains(_guess))
                {
                    _terminal.PrintString("You have already guessed that letter. Please try a different one.");
                    _guess = _terminal.ReadInput();
                }
                _guesses.Add(_guess);
                if (!compareLetter(_guess))
                {
                    _parachute.wrongGuess();
                }
                else
                {
                    updateDisplayedWord();
                }
                outputDisplayedWord();

                if (_parachute.listRange < 3)
                {
                    _isPlaying = false;
                    _parachute.drawJumper();
                    Console.WriteLine("YOU LOSE SIR\n");
                    break;
                }

                if (!_displayWord.Contains('_'))
                {
                    _isPlaying = false;
                    Console.WriteLine("congratz i guess\n");
                }

            } while (_isPlaying);
        }

        // Compares the guess letter with the secret word
        private bool compareLetter(char letter)
        {
            bool correctGuess = false;
            if (_secretWord.Contains(letter))
            {
                correctGuess = true;
            }
            return correctGuess;
        }

        private void updateDisplayedWord()
        {
            for (int iWord=0; iWord<_secretWord.Length; iWord++)
            {
                for (int iGuesses=0; iGuesses<_guesses.Count; iGuesses++)
                {
                    if (_secretWord[iWord] == _guesses[iGuesses])
                    {
                        _displayWord[iWord] = _secretWord[iWord];
                    }
                }
            }
        }

        private void outputDisplayedWord()
        {
            foreach (char character in _displayWord)
            {
                Console.Write($" {character}");
            }
            Console.WriteLine("\n");
        }
    }
}