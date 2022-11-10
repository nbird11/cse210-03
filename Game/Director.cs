using System;
using System.Collections.Generic;

namespace Game
{
    /// Director keeps track of the game loop, and the guessed letters, updates the hint
    public class Director
    {
        // Attributes
        private bool _isPlaying = true;
        private Parachute _parachute = new Parachute();
        private TerminalService _terminal = new TerminalService();
        private Dictionary _dictionary = new Dictionary();
        private string _secretWord;
        private List<char> _hint = new List<char>();
        private List<char> _guesses = new List<char>();
        private char _guess;

        // Constructor
        public Director()
        {
            _secretWord = _dictionary.getWord();
            foreach (char letter in _secretWord)
            {
                _hint.Add('_');
            }
        }

        // Methods
        // Game loop
        public void startGame()
        {
            do
            {
                // PUT hint
                displayHint();

                // Draw jumper guy
                _parachute.drawJumper();

                // GET input _guess
                _guess = _terminal.ReadInput();

                // Check if the letter was already guessed
                while (_guesses.Contains(_guess))
                {
                    _terminal.PrintString("You have already guessed that letter. Please try a different one.\n");
                    _guess = _terminal.ReadInput();
                }

                _guesses.Add(_guess);

                // Compare _guess with _secretWord
                if (!compareLetter(_guess))
                {
                    // _guess doesn't match
                    _parachute.wrongGuess();
                }
                else
                {
                    // _guess matches
                    updateHint();
                }

                // Lose condition.
                if (_parachute.listRange < 3)
                {
                    _isPlaying = false;
                    _parachute.drawJumper();
                    Console.WriteLine("YOU LOSE SIR!");
                    Console.WriteLine($"Secret word was {_secretWord}.\n");
                    break;
                }

                // Win condition.
                if (!_hint.Contains('_'))
                {
                    displayHint();
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

        // Makes sure the '_'s in _hint are replaced with the guesses if they match _secretWord
        private void updateHint()
        {
            for (int iWord=0; iWord<_secretWord.Length; iWord++)
            {
                for (int iGuesses=0; iGuesses<_guesses.Count; iGuesses++)
                {
                    if (_secretWord[iWord] == _guesses[iGuesses])
                    {
                        _hint[iWord] = _secretWord[iWord];
                    }
                }
            }
        }

        // Prints the _hint to the screen char by char.
        private void displayHint()
        {
            Console.WriteLine();
            foreach (char character in _hint)
            {
                Console.Write($" {character}");
            }
            Console.WriteLine("\n");
        }
    }
}