using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;



namespace TextAdventureGame
{
    class TextAdventure
    {
        public void Run()
        {
            Console.Write("CONSOLE : ");
            TypeText(
                "Welcome to the text adventure game!\n          " +
                "This adveture is based in the year 3023, your goal, survive as long as possible and explore! You can quit at anytime by typing `q` when the options appear.\n          " +
                "You read to start?\n"
                );

            // Game loop
            while (true)
            {
               
                Console.Write("CONSOLE : ");
                TypeText("Enter command to continue\n\n          " +
                    "(Q) Quit\n          " +
                    "(h) Help\n          " +
                    "(s) Start\n          " +
                    "Input : ");
                string input = Console.ReadLine().ToLower();

                // Process the player's input
                if (input == "q")
                {
                    Console.WriteLine("Thanks for playing!");
                    return;
                }
                else if (input == "h")
                {
                    Console.Write("CONSOLE : ");
                    TypeText("Commands are -\n\n          " +
                        "(Q) Quit\n          " +
                        "(h) Help\n          " +
                        "(s) Start\n          "
                        );
                }
                else if (input == "s")
                {
                    AdentureStart game = new AdentureStart();
                    game.Run();
                }
                else
                {
                    Console.Write("CONSOLE : ");
                    TypeText("Unknown command.");
                }
            }
        }
        static void TypeText(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(100);
            }
            Console.Write("_"); // Add a blinking cursor at the end of the text
            Thread.Sleep(500);
            Console.Write("\b"); // Erase the blinking cursor
            Thread.Sleep(500);
            Console.Write("_"); // Add the blinking cursor again
            Thread.Sleep(500);
            Console.Write("\b"); // Erase the blinking cursor
        }
    }
}
