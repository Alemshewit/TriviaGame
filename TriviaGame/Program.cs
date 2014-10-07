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
        static public bool keepPlaying = true;
        static public int playerScore = 0;

        static void Main(string[] args)
        {
            //call greet function to greet player
            //The logic for your trivia game happens here
            List<Trivia> AllQuestions = GetTriviaList();
            int correctAnswer = 0;
            int wrongAnswer = 0;
            int totalPlayed = 0;
            bool keepPlaying = true;
            Random rng = new Random();
            Console.WriteLine("What's your name?");
            string userInput = Console.ReadLine();
            Console.WriteLine("Welcome to Trivia " + userInput);

            while (keepPlaying)
            {
                //get a random number between 1 and 5001 and store it in the 
                //int variable askRand
                int randQuestion = rng.Next(1, 5001);

                Console.WriteLine("Question: " + AllQuestions[randQuestion].Question);
                Console.WriteLine("What is the answer?");
                string userResponse = Console.ReadLine();

                if (AllQuestions[randQuestion].Answer.ToLower() == userResponse.ToLower())
                {
                    correctAnswer += 1;
                    totalPlayed += 1;
                    Console.WriteLine("Good job! That's the right answer!");
                    Console.Clear();
                }
                else
                {
                    wrongAnswer += 1;
                    totalPlayed += 1;
                    Console.WriteLine("Wrong Answer! Right answer is: " +AllQuestions[randQuestion].Answer);
                    Console.Clear();
                    
                }

                if (totalPlayed == 10)
                {
                    //print to console to ask player if he or she wants to keep playing
                    Console.WriteLine("Do you want to keep playing? Type yes or no");
                    //store the player response converted to lower case in the string
                    //variable userInput
                    string userinput = Console.ReadLine().ToLower();
                    //check the conditions if the user response is no, then return false for the funtion
                    //else return true and go back in the while loop
                    if (userInput.ToLower() == "no")
                    {
                        //if no return false the the while loop ends there
                        keepPlaying = false;
                        totalPlayed = 0;
                    }
                    else if (userinput == "yes")
                    {
                        //if yes return true and go back into the while and keep playing a new game
                        keepPlaying = true;
                        totalPlayed = 0;
                    }
                    else
                    {
                        //if user enters other than yes or no, instruct to type in yes or no and go back 
                        //into the if statment
                        Console.WriteLine("Please type in the appropriate response");
                    }

                }
            }

            //output final result on to the console to reveal player score
            Console.WriteLine("You answered " + correctAnswer + " questions correctly " + 
                "\nYou answered " + wrongAnswer + " questions wrong");
            //Call the function keepplaying to ask player if he or she wants to keep playing

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
            foreach (var item in contents)
	        {
		        Trivia newTrivia = new Trivia(item);
                returnList.Add(newTrivia);
	        }

            return returnList;
        }

        //create a new KeepPlaying function that check to see if the player wants to 
        //keep playing 


        //static void HighScores(int playerScore)
        //{
        //    Console.WriteLine("Your name:");
        //    string playerName = Console.ReadLine();

        //    AlemEntities db = new AlemEntities();

        //    HighestScore newHighestScore = new HighestScore();
        //    newHighestScore.DateCreated = DateTime.Now;
        //    newHighestScore.Game = "Guess That Number";
        //    newHighestScore.Name = playerName;
        //    newHighestScore.Score = playerScore;

        //    db.HighestScores.Add(newHighestScore);

        //    db.SaveChanges();
        //}

        //static void DisplayHighestScore()
        //{
        //    Console.Clear();
        //    Console.WriteLine("Guess That Number High Scores");
        //    Console.WriteLine("*****************************");

        //    AlemEntities db = new AlemEntities();
        //    List<HighestScore> highestScoreList = db.HighestScores
        //        .Where(x => x.Game == "Guess That Number")
        //        .OrderBy(x => x.Score).Take(10)
        //        .ToList();

        //    foreach (HighestScore highScore in highestScoreList)
        //    {
        //        Console.WriteLine("{0}. {1} - {2} on {3}",
        //            highestScoreList.IndexOf(highScore) + 1,
        //            highScore.Name,
        //            highScore.Score,
        //            highScore.DateCreated.Value.ToShortDateString());
        //    }
        //    Console.WriteLine("\n\n\n");


        }

    }

    




