using System;

namespace basicProgram
{
    class BasicCheck
    {
        public string checkMe(string words)
        {
            string message = string.IsNullOrEmpty(words) ? "the string is empty!" : "The string is not empty!";
            return message;
        }
    }
}