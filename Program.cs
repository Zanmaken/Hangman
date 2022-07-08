using System;

namespace HangmanGame
{
    class HangmanGame
    {   
        
        static void Main(string[] args)
        {
            //Test change for github
            MainMenu();
        }

        static void MainMenu()
        {
            string[] mainMenuButtons = {"1P Mode", "2P Mode", "Scoreboard", "Tutorial", "Exit"};
            Console.Clear();
            while (true)
            {   
                int buttonCount = 1;
                Console.WriteLine("Welcome to the Hangman word game!");
                foreach(string button in mainMenuButtons)
                {
                    Console.WriteLine($"{buttonCount}.{button}");
                    buttonCount++;
                }       
                Console.Write("Choose one of the options by typing in it's number: ");
                int userInputAsInt;
                while (true)
                {
                    string userInput = Console.ReadLine();                    
                    if(!Int32.TryParse(userInput, out userInputAsInt))
                    {
                        Console.WriteLine($"Input has to be a number! Please choose an option again: ");
                        continue;
                    }
                    if(userInputAsInt < 1 || userInputAsInt > mainMenuButtons.Length)
                    {
                        Console.WriteLine($"Wrong input, the number has to be between 1 and {mainMenuButtons.Length}! Please input it again: ");
                        continue;
                    }
                    break;
                }
                switch (userInputAsInt)
                {
                    case 1:
                        Console.WriteLine("Entering 1P Mode");
                        break;
                    case 2:
                        Console.WriteLine("Entering 2P Mode");
                        break;
                    case 3:
                        Console.WriteLine("Entering the Scoreboard");
                        break;
                    case 4:
                        Console.WriteLine("Entering the Tutorial");
                        break;
                    case 5:
                        Console.WriteLine("Exiting the game! Bye :3");
                        break;
                }
                break;
            }
            Console.ReadKey();
        }

        static void OnePlayerMode()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("One player mode choosen. Please type in your name below: ");
                string username = Console.ReadLine();

            }
        }
    }
}
