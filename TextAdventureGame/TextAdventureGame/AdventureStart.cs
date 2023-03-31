namespace TextAdventureGame
{
    
    class AdentureStart
    {
        
        private int userLives = 3;
        private int userScore = 0;

        /// <summary>
        /// The run class, this class is called by Run()
        /// </summary>
        public void Run()
        {
		    
            string userName;
            string userInput;
            int choice;
            



           
            Console.Write("STRANGER : ");
            TypeText(
                "Welcome to the future stranger...\n"
                );
            Thread.Sleep(1000);
            Console.Write("STRANGER : ");
            TypeText(
                "The year is 3023, all human life has cease to exist and the left over animals have mutated into super beasts!\n"
                );

            Console.Write("STRANGER : ");
            TypeText(
                "What shall I call you to help you through this adventure? "
                );
            userName = Console.ReadLine();


            Console.Write("STRANGER : ");
            TypeText(
                $"Hello {userName} I am \"NOVA\" your personal guide through this futuristic adventure.\n\nShall we start? . . .\nLets go!\n"
                );

            
            while (true)
            {
                if (userLives == 0)
                {
                    Console.Write("NOVA : ");
                    TypeText("Uhoh . . . you lost all of your lives . . .");
                    Environment.Exit(0);
                }
                else
                {
                    Console.Write("NOVA : ");
                    TypeText("\n(E) Explore\n(Q) Quit\n(V) View Score\n\nInput : ");
                    userInput = Console.ReadLine().ToUpper();
                    bool myBool = true;

                    if (userInput == "E")
                    {

                        choice = GetRandomChoice();
                        switch (choice)
                        {
                            case 0:
                                Console.Write("NOVA : ");
                                userScore += 20;
                                TypeText("You went out exploring and you found an old rundown store that had some old supplies in it!\n\n+20 Points\n");
                                break;
                            case 1:
                                Console.Write("NOVA : ");
                                TypeText("You ran into a rabbid Gorilla!!");
                                while (myBool)
                                {
                                    TypeText("\n\n(F) Fight\n(R) Run\n(H) Hide\n\nInput : ");
                                    userInput = Console.ReadLine().ToUpper();
                                    if (userInput == "F")
                                    {
                                        choice = GetRandomChoice();
                                        switch (choice)
                                        {
                                            case 0:
                                                userScore += 5;
                                                Console.Write("NOVA : ");
                                                TypeText("You chose to fight the rabbid gorilla and you won!\n\n+5 Point\n");
                                                myBool = false;
                                                break;

                                            case 1:

                                                Console.Write("NOVA : ");
                                                TypeText("You got badly injured from fighting the rabbid gorrilla but you managed to survive!\n\n+0 Points\n");
                                                myBool = false;
                                                break;
                                            case 2:
                                                userScore = 0;
                                                userLives -= 1;
                                                Console.Write("NOVA : ");
                                                TypeText("You chose to fight the rabbid gorilla and sadly you died.\n\nYou lost all of your points\n");
                                                myBool = false;
                                                break;
                                            default:
                                                Console.Write("CONSOLE : ");
                                                TypeText("Error . . . An error has occoured please try again . . .\n");
                                                myBool = false;
                                                break;
                                        }
                                        break;
                                    }
                                    else if (userInput == "R")
                                    {
                                        choice = GetRandomChoice();
                                        switch (choice)
                                        {
                                            case 0:
                                                
                                                Console.Write("NOVA : ");
                                                TypeText("You chose to run the rabbid gorilla and you managed to escape it *phew*\n\n+0 Point\n");
                                                break;
                                            case 1:
                                                userScore = 0;
                                                userLives -= 1;
                                                Console.Write("NOVA : ");
                                                TypeText("You ran away from the rabbid gorilla but he was faster than you . . . he caught you and ate you!\n\nYou lost all of your points\n");
                                                break;
                                            case 2:
                                                userScore += 10;
                                                Console.Write("NOVA : ");
                                                TypeText("You tried running away from the rabbid gorilla and the gorilla fell into a hole and died\n\n+5 Points\n");
                                                break;
                                            default:
                                                Console.Write("CONSOLE : ");
                                                TypeText("Error . . . An error has occoured please try again . . .\n");
                                                break;
                                        }
                                    }
                                    else if (userInput == "H")
                                    {
                                        choice = GetRandomChoice();
                                        switch (choice)
                                        {
                                            case 0:
                                                userScore += 10;
                                                Console.Write("NOVA : ");
                                                TypeText("You chose to hide from the rabbid gorilla but you found some weapons in a storage chest\n\n+10 Point\n");
                                                break;
                                            case 1:
                                                userScore = 0;
                                                userLives -= 1;
                                                Console.Write("NOVA : ");
                                                TypeText("You tried to hide but spooked some mutant turtles and alerted the rabbid gorilla to your position\n\nYou lost all of your points\n");
                                                break;
                                            case 2:
                                                userScore += 5;
                                                Console.Write("NOVA : ");
                                                TypeText("You managed to hide from the rabbid gorilla.\n\n+5 Points\n");
                                                break;
                                            default:
                                                Console.Write("CONSOLE : ");
                                                TypeText("Error . . . An error has occoured please try again . . .\n");
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        Console.Write("NOVA : ");
                                        TypeText("Error . . . Please enter only the approved inputs . . .\n");
                                    }
                                    break;

                                }
                                break;
                            case 2:
                                userScore += 50;
                                Console.Write("NOVA : ");
                                TypeText("You found a boat!\n\n+50 Points");
                                // Handle straight path outcome
                                break;
                            default:
                                Console.Write("CONSOLE : ");
                                Console.WriteLine("Error . . . An error has occoured please try again . . .");
                                break;
                        }


                    }
                    else if (userInput == "Q")
                    {
                        Console.Write("NOVA : ");
                        TypeText($"Been great playing with you {userName}, I hope to play with again!\n");
                        Thread.Sleep(1000);
                        TypeText("Game quit");
                        Environment.Exit(0);
                    }
                    else if (userInput == "V")
                    {
                        Console.Write("NOVA : ");
                        
                        TypeText($"Your score {userName} is:\n{userScore}\n");

                    }
                    else
                    {
                        Console.Write("NOVA : ");
                        TypeText($"Unknown command.\n");
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
            
            static int GetRandomChoice()
            {
                Random rand = new Random();


                int choice = rand.Next(3);


                return choice;
            }
            //static int userScore(int points)
            //{
            //    int userScore;
            //    int userPoints;
            //    if (points == 1)
            //    {
            //        userPoints = 0;
            //    }
            //    else
            //    {
            //        userPoints =+ points;
            //    }
            //    return userPoints;
            //}
        }
	}
        
}

