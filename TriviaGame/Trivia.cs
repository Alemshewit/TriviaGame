using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame
{
    class Trivia
    {
        //TODO: Fill out the Trivia Object
        
        //The Trivia Object will have 2 properties
        // at a minimum, Question and Answer
        public string Question { get; set; }
        public string Answer { get; set; }

        //The Constructor for the Trivia object will
        // accept only 1 string parameter.  You will
        // split the question from the answer in your
        // constructor and assign them to the Question
        // and Answer properties
        public Trivia(string triviaQandA)
        {
            //creat a new List variable to hold our questions and answers
            List<string> triviaQuestions = new List<string>();
            //split the argument into to indexes along the *
            //and populate the new list with the new values
            triviaQuestions = triviaQandA.Split('*').ToList();

            //the property question will get the first index in the list 
            this.Question = triviaQuestions[0];
            //the property answer will get the second index in the list
            this.Answer = triviaQuestions[1];

        }

    }
}
