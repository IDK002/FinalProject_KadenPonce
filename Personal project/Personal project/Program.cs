using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;

public class PersonalProject
{
    public static void Main(string[] args)
    {
        bool alive;
        {
            alive = true;
        }
        Console.WriteLine("Through The Woods \n------- PRESS ENTER TO START -------");
        Console.ReadLine();
        Console.WriteLine("A little kid named Jack goes walking through the woods");
        Console.WriteLine("Would you like to move Jack to the right or left path? \nType right for the right path or type left for left path");
        string response = Console.ReadLine();
        
        if(response == "right")
        {
            Console.WriteLine("You picked the right path");
            Console.WriteLine ("You died to a wolf disguised as a grandma");
            alive = false;
                return;
        }
        else
        {
            Console.WriteLine("You choose the left path");
            Console.WriteLine("Little Jacky Wacky walks down the " + response + " path and discovers a deadly penguin");
            Console.WriteLine("You have to fight the deadly penguin!");
            Random random = new Random();
            int playerHp = 50;
            int enemyHp = 50;
            int playerAttack;
            int enemyAttack;
            int healAmount = 6;
            
            while (playerHp > 0 && enemyHp > 0)
            {
                Console.WriteLine("You have " + playerHp + " health");
                Console.WriteLine("Dark Knight Devin has " + enemyHp + " health");
                Console.WriteLine("--- Player turn ---");
                Console.WriteLine("Enter 'a' to attack or 'h' to heal");
                string choice = Console.ReadLine();
                if (choice == "a")
                {
                    playerAttack = random.Next(1, 16);
                    enemyHp -= playerAttack;
                    Console.WriteLine("Jack attacks the enemy and dealt " + playerAttack + " damage!");
 
                  
                }
                if (choice == "h" && playerHp > 45)
                {
                    Console.WriteLine("You have or nearly have full health you big baby");
                    healAmount = random.Next(0,1);
                    
                }
                if (choice == "h" && playerHp < 45)
                {
                    playerHp += healAmount;
                    Console.WriteLine("Little Jacky Wacky restores " + healAmount + " health points");  
                }
                if(enemyHp > 0)
                {
                    Console.WriteLine("--- Dark Knight Devin's turn ---");
                    int enemyChoice = random.Next(0, 3);
                    if (enemyChoice == 1)
                    {
                        enemyAttack = random.Next(1, 16);
                        playerHp -= enemyAttack;
                        Console.WriteLine("Dark Knight Devin attacks and deals " + enemyAttack + " damage");
                    }
                   if (enemyChoice == 2 && enemyHp < 45)
                   {
                        enemyHp += healAmount;
                        Console.WriteLine("Dark Knight Devin restores " + healAmount + " health points");
                   }
                   if (enemyChoice == 2 && enemyHp > 45)
                   {
                        healAmount = 0;
                        playerAttack = 0;
                   }
                }
                if (enemyHp < 1)
                {
                    Console.WriteLine("Jack has defeated Dark Knight Devin \nGood job you big buffoon");
                    Console.WriteLine("Little Jacky keeps walking down the left path and three more paths open up: A right  \n which path do you want to go down?");
                    response = Console.ReadLine();
                    if (response == "left")
                    {
                        Console.WriteLine("Henry Quinn appears out of a tree and smacks silly Jacky Wacky into his place");
                        alive = false;
                    } 
                    //Jonah X
                    if (response == "right")
                    {
                        Console.WriteLine("As Jacky walks down the right path and looks behind him and notices Henry Quinn running at him \n Does Jacky stand his ground (type yes or no)");
                        response = Console.ReadLine();
                        if (response == "yes") 
                        {
                            Console.WriteLine("Henry Quinn smacks you with a bat and down Jack goes");
                            alive = false;
                        }
                        else
                        {
                            Console.WriteLine("Jacky runs away like greasy gremlin");
                            Console.WriteLine("Jack finds Ant-man Avery running away from a dog about to get squished \n Would you like to save her or squish him (Type save or squish)?");
                            if (response == "save")
                            {
                                Console.WriteLine("Jacky is a dumb and belly flops on Ant-man Avery and he screams in agony as his last breath leaves");
                                Console.WriteLine("Ant-man Avery goes back her original size and pierces Jack");
                                    alive = false;
                            }
                            else
                            {
                                Console.WriteLine("Jack has the best vision ever and chose to step on Ant-man Avery");
                                Console.WriteLine("That was the final boss congrations you -- \ndied because Henry Quinn smacked you in the back of the head \n The end");
                                alive = false;
                            }
                        }
                    }
                }
            }
        }
    }
}

