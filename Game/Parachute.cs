using System;
using System.Collections.Generic;

namespace CSE210_03
{
    /// Parachute
    public class Parachute
    {
        List<string> jumper = new List<string>();
        
        int listRange;


        public Parachute()
        {
            jumper.Add("  / \\  ");
            jumper.Add("  /|\\  ");
            jumper.Add("   0   ");         
            jumper.Add("  \\ /  ");
            jumper.Add(" \\   / ");
            jumper.Add(" /___\\ ");
            jumper.Add("  ___  ");

            listRange = jumper.Count;
        }

        public void wrongGuess()
        {
            listRange -= 1;
        }

        public void drawJumper()
        {
            if (listRange > 2)
            {
                for (int i = listRange - 1; i > -1; i--)
                {
                    Console.WriteLine(jumper[i]);
                }
            }
            else
            {
                Console.WriteLine("   x   ");
                for (int i = listRange - 1; i > -1; i--)
                {
                    Console.WriteLine(jumper[i]);
                }
            }
                       
        }

        
    }
        
}
