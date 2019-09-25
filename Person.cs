using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Introduction_Explained
{
    class Person
    {
        // Declare a field to represent the personality
        private string personality;

        // Constructor
        public Person()
        {
            personality = "Mystery";
        }

        public void AskQuestion(int answer)
        {
            if(answer == 1)
            {
                personality = " ";
            }
            else if(answer == 2)
            {
                personality = "Introvert";
            }
            else
            {
                personality = "You are still a Mystery";
            }
        }

        // This method returns the value of the Personality
        public string GetPersonality()
        {
            return personality;
        }
    }
}
