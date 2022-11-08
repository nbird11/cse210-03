using System;
using System.Collections.Generic;

namespace CSE210_03{
    public class Dictionary{
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
        public string getWord(){
            return currentWord;
        }
        public void getRandomWord(){
            currentWord = words[random.Next(words.Count)];
        }
        public Dictionary(){
            getRandomWord();           
        }
    }
}