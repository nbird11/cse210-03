using System;
using System.Collections.Generic;

namespace CSE210_03{
    // Dictionary will keep track of words and get a random word for the secret word.
    public class Dictionary{
        // Attributes
        private List<string> words = new List<string>() {
            "fluffy",
            "postal",
            "forge",
            "salami",
            "stomp",
            "alter",
            "something",
            "rhythm",
            "infinite",
            "deprive",
            "relax",
            "breakdown",
            "represent",
            "critical",
            "sunrise",
            "president"
        };
        private Random random = new Random();
        private string currentWord = "";

        // Constructor
        public Dictionary(){
            getRandomWord();           
        }

        // Methods
        public string getWord(){
            return currentWord;
        }
        public void getRandomWord(){
            currentWord = words[random.Next(words.Count)];
        }

        
    }
}