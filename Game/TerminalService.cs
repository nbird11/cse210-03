using System;
using System.Collections.Generic;

namespace Game
{
    /// TerminalService
    /// Terminal service is here to provide functions for the rest of the code to interact with the terminal
    /// will include prints and receive inputs.
    public class TerminalService 
    {
        /// attributes

        /// constuctor to build the object
        public TerminalService()
        {
        }

        /// method
        public char ReadInput(string prompt = "Guess a letter [a-z]: ")
        {
            Console.Write(prompt);
            char input = Convert.ToChar(Console.ReadLine());
            return input;
        }


        public void PrintString(string output)
        {
            Console.WriteLine(output);
        }

        public void PrintList(List<string> outputs)
        {
            foreach (string item in outputs)
            {
                PrintString(item);
            }
        }
    }
}