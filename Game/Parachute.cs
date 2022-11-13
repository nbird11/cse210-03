using System;
using System.Collections.Generic;

namespace Game
{
    /// Parachute
    public class Parachute
    {
        private List<string> jumper = new List<string>();
        
        private int _listRange;

        public int listRange {
            get
            {
                return _listRange;
            }
            set
            {
                _listRange = value;
            }
        }

        public Parachute()
        {
            jumper.Add("  / \\  ");
            jumper.Add("  /|\\  ");
            jumper.Add("   0   ");         
            jumper.Add("  \\ /  ");
            jumper.Add(" \\   / ");
            jumper.Add(" /___\\ ");
            jumper.Add("  ___  ");

            _listRange = jumper.Count;
        }

        public void wrongGuess()
        {
            _listRange -= 1;
        }

        public void drawJumper()
        {
            if (_listRange > 2)
            {
                for (int i = listRange - 1; i > -1; i--)
                {
                    Console.WriteLine(jumper[i]);
                }
            }
            else
            {
                Console.WriteLine("   x   ");
                for (int i = _listRange - 1; i > -1; i--)
                {
                    Console.WriteLine(jumper[i]);
                }
            }
                       
        }

        
    }
        
}
