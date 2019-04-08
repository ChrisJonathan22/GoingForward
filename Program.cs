using System;

namespace GoingForward
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Log app info
            AppInfo.GetAppInfo();

            // Greet the player
            Greeting.GreetUser();

            // Change the console's text color to the color below 
            Console.ForegroundColor = ConsoleColor.Blue; 

            // Ask the player if they are ready to play
            Console.WriteLine("Are you ready to play? [ Y | N ]");

            // Reset the console's text color
            Console.ResetColor();
            
            // Store the user's answer
            string userAnswer = Console.ReadLine().ToUpper();

            // If the player is ready to play log the following
            if(userAnswer == "Y") {
                Console.WriteLine("Great!");

                int playerMoves = 0;

                while (playerMoves < 5) {
                    // Generate a random number between 0 & 2
                    int rand = CreateRandomNumber.GenerateRandomNumber();

                    // Tell the player what they need to do in order to win
                    Console.WriteLine("To win the game you need to reach level 5 by entering 5 correct numbers in a row.");

                    // Ask the player to enter a number
                    Console.WriteLine("Please enter a number between 0 & 2");

                    // Give the player instructions on what to do in order to exit
                    Console.WriteLine("To exit the game simply type in 3 and enter");

                    // Convert the player's input to an int and store it
                    int playerInput = Int32.Parse(Console.ReadLine());

                    // If the player enters a number which matches the random number then do this
                    if(rand == playerInput) {
                        playerMoves += 1;
                        Console.WriteLine($"You're on level {playerMoves}");
                            if(playerMoves == 10) {
                                Console.WriteLine($"Congratulations you've reached level {playerMoves}!");
                            }
                    }

                    // If the player enters 3 return / exit the game
                    else if(playerInput == 3) {
                        return;
                    }

                    // If the player's number doesn't match the random number then do this
                    else {
                        playerMoves = playerMoves == 0 ? 0 : playerMoves - 1;
                        Console.WriteLine($"You're on level {playerMoves}");
                    }
            }
            }
            // If the player isn't ready to play log the following
            else {
                Console.WriteLine("Maybe next time!");
            }
        }
    }


    public class AppInfo {
        public static void GetAppInfo() {
            // Store app info
            string appAuthor = "Chris Jonathan";
            string appName = "Going Forward";
            string appVersion = "1.0.0";
            // Log app info
            Console.WriteLine($"{appName} - Version {appVersion} by {appAuthor}.");
        }
    }
    public class Greeting {
       public static void GreetUser() {
        // Change the console's text color to the color below  
         Console.ForegroundColor = ConsoleColor.Blue; 

        // Ask the user for their name
        Console.WriteLine("Hello friend! what is your name?");

        // Reset the console's text color
        Console.ResetColor(); 

        // Change the console's text color to the color below  
        Console.ForegroundColor = ConsoleColor.Yellow; 

        // Store the user's name
        string userName = Console.ReadLine();

        // Change the console's text color to the color below 
        Console.ForegroundColor = ConsoleColor.Blue; 

        // Welcome the user to the game
        Console.WriteLine($"Welcome to the game {userName}!");

        // Change the console's text color to the color below 
        Console.ForegroundColor = ConsoleColor.Blue; 

        // Introduce the game operator to the user
        Console.WriteLine("My name is Jarvis, you can refer to me as Jarvis the great!");

        // Reset the console's text color
        Console.ResetColor(); 
        }
    }

    public class CreateRandomNumber {
        public static int GenerateRandomNumber () {
            // Create a new random object
            Random random = new Random();

            // Get a random number between 0 & 2
            int randomNumber = random.Next(0,3);

            // Return random number
            return randomNumber;
        }
    }
}
