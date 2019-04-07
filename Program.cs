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
}
