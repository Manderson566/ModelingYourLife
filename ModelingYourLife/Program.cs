using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelingYourLife
{
    class Program
    {
        static void Main(string[] args)
        {
            bool retry = true;
            while (retry)
            {
                Console.WriteLine("Enter Your Running Man Name");
                string playerName = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine($"Welcome {playerName} to Running Man! To Play Type Jump or Duck Into The Console.");
                Console.WriteLine("You Are Trying To Jump Over Or Duck Under Obsticals Before You See Them.");
                Console.WriteLine("Your Charater has 3 Stamina If You Trip Too Many Times He Falls.");
                Console.WriteLine("");

                

                RunningMan runner = new RunningMan(playerName);
                //Console.WriteLine(rndObject);
                int turns = 5;
                while (runner.currentState == State.Standing && turns > 0)
                {
                    Objects rndObject = new Objects("Mystery object");
                    string randomObject = rndObject.ToString();
                    string jump = "jump";
                    string duck = "duck";
                    Console.WriteLine($"You have {turns} turns remaining");
                    if ((randomObject == "Ladder") || (randomObject == "Bridge"))
                    {
                        Console.WriteLine("Do You Want To Jump Or Duck?");
                        string jumpDuckSelect = Console.ReadLine();
                        Console.Clear();

                        if (jumpDuckSelect == duck.ToLower())
                        {
                            Console.WriteLine($"A Sucsessfull Jump {runner} Stamina Remaining");

                        }
                        else
                        {
                            runner.ReduceStam();
                            Console.WriteLine($"{runner} Stamina: You Tripped, -1 to Stamina");

                        }
                    }
                    else
                    {
                        Console.WriteLine("Do You Want To Jump Or Duck?");
                        string jumpDuckSelect = Console.ReadLine();
                        Console.Clear();
                        if (jumpDuckSelect == jump.ToLower())
                        {
                            Console.WriteLine($"A Sucsessfull Jump {runner} Stamina Remaining");

                        }
                        else
                        {
                            runner.ReduceStam();
                            Console.WriteLine($"{runner} Stamina: You Tripped, -1 To Stamina");

                        }
                    }
                    turns--;
                    Console.WriteLine($"The Object Was a {rndObject}");
                    Console.WriteLine("");
                }
                if (turns == 0)
                {
                    Console.WriteLine("WINNER!!!!!!!!!!!!!!!");
                    Console.WriteLine("Type ( Y )  To Play Agian");
                    string playAgainCK = Console.ReadLine();
                    if (playAgainCK.ToUpper() == "Y")
                    {
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("YOU FELL! Play Again And Improve Your Skills");
                    Console.WriteLine("Type ( Y )  To Play Agian");
                    string playAgainCK = Console.ReadLine();
                    if (playAgainCK.ToUpper() == "Y")
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine("Goodbye");
            retry = false;
        }
    }
}
