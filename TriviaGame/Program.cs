using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //call greet function to greet player
            Greeting();
            //The logic for your trivia game happens here
            List<Trivia> AllQuestions = GetTriviaList();
            int correctAnswer = 0;
            int wrongAnswer = 0;
            bool playing = true;
            Random rng = new Random();

            while (playing == true)
            {
                int question = rng.Next(1, 5001);
                
            }


        }


        //This functions gets the full list of trivia questions from the Trivia.txt document
        static List<Trivia> GetTriviaList()
        {
           

            //Get Contents from the file.  Remove the special char "\r".  Split on each line.  Convert to a list.
            List<string> contents = File.ReadAllText("trivia.txt").Replace("\r", "").Split('\n').ToList();

            //Each item in list "contents" is now one line of the Trivia.txt document.
            
            //make a new list to return all trivia questions

            List<Trivia> returnList = new List<Trivia>();
            // TODO: go through each line in contents of the trivia file and make a trivia object.
            //       add it to our return list.
            // Example: Trivia newTrivia = new Trivia("what is my name?*question");
            //Return the full list of trivia questions
            return returnList;
        }

        static void Greeting()
        {
           Console.WriteLine("Hello! Here are fun trivia games for you to play!");

        }
    }
}
