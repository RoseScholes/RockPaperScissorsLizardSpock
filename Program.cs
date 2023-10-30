internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();

        int playerScore = 0;
        int enemyScore = 0;

        Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock!");
        Console.WriteLine();
        Console.WriteLine("Please enter your name: ");
        string userName = Console.ReadLine();
        Console.WriteLine($"Greetings, {userName}");

        while (playerScore + enemyScore != 3 && playerScore != 2 && enemyScore !=2)
        {
            Console.WriteLine("Player Score = " + playerScore + " Enemy Score = " + enemyScore);
            Console.WriteLine("Please enter your choice...");
            string playerChoice = Console.ReadLine();

            int enemyChoice = random.Next(0, 5);

            if (enemyChoice == 0)
            {
                Console.WriteLine("Enemy chooses rock.");
                switch (playerChoice)
                {
                    case "rock":
                        Console.WriteLine("It's a tie.");
                        break;
                    case "paper":
                        Console.WriteLine("You win this round!");
                        playerScore++;
                        break;
                    case "scissors":
                        Console.WriteLine("You lose this round.");
                        enemyScore++;
                        break;
                    case "lizard":
                        Console.WriteLine("You lose this round.");
                        enemyScore++;
                        break;
                    case "Spock":
                        Console.WriteLine("You win this round!");
                        playerScore++;
                        break;
                }
            }
            else if (enemyChoice == 1)

            {
                Console.WriteLine("Enemy chooses paper.");
                switch (playerChoice)
                {
                    case "rock":
                        Console.WriteLine("You lose this round.");
                        enemyScore++;
                        break;
                    case "paper":
                        Console.WriteLine("It's a tie!");
                        break;
                    case "scissors":
                        Console.WriteLine("You win this round!");
                        playerScore++;
                        break;
                    case "lizard":
                        Console.WriteLine("You win this round!");
                        playerScore++;
                        break;
                    case "Spock":
                        Console.WriteLine("You lose this round.");
                        enemyScore++;
                        break;
                }
            }
            else if (enemyChoice == 2)
            {
                Console.WriteLine("Enemy chooses scissors.");
                switch (playerChoice)
                { case "rock":
                        Console.WriteLine("You win this round!");
                        playerScore++;
                        break;
                    case "paper":
                        Console.WriteLine("You lose this round.");
                        enemyScore++;
                        break;
                    case "scissors":
                        Console.WriteLine("It's a tie.");
                        break;
                    case "lizard":
                        Console.WriteLine("You lose this round.");
                        enemyScore++;
                        break;
                    case "Spock":
                        Console.WriteLine("You win this round!");
                        playerScore++;
                        break; 
                }
                    
            }
            else if (enemyChoice == 3)
            {
                Console.WriteLine("Enemy chooses lizard.");
                switch (playerChoice)
                { case "rock":
                        Console.WriteLine("You win this round!");
                        playerScore++;
                        break;
                    case "paper":
                        Console.WriteLine("You lose this round.");
                        enemyScore++;
                        break;
                    case "scissors":
                        Console.WriteLine("You win this round!");
                        playerScore++;
                        break;
                    case "lizard":
                        Console.WriteLine("It's a tie.");
                        break;
                    case "Spock":
                        Console.WriteLine("You lose this round.");
                        enemyScore++;
                        break;
                }

            }
            else
            {
                Console.WriteLine("Enemy chooses Spock.");
                switch (playerChoice)
                { case "rock":
                        Console.WriteLine("You win this round!");
                        playerScore++;
                        break;
                    case "paper":
                        Console.WriteLine("You win this round!");
                        playerScore++; 
                        break;
                    case "scissors":
                        Console.WriteLine("You lose this round.");
                        enemyScore++;
                        break;
                    case "lizard":
                        Console.WriteLine("You lose this round.");
                        enemyScore++;
                        break;
                    case "Spock":
                        Console.WriteLine("It's a tie");
                        break;
                }
                
            }
            
        }
        if (playerScore > enemyScore)
        {
            Console.WriteLine($"{userName} wins! Congratulations!");
        }
        else if (playerScore < enemyScore)
        {
            Console.WriteLine($"Better luck next time, {userName}");
        }

    }
}