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
            Objects rndObject = new Objects("Mystery object");
            RunningMan runner = new RunningMan("Runner");
            //Console.WriteLine(rndObject);
            int turns = 5;
            string randomObject = rndObject.ToString();
            while (runner.currentState == State.Standing && turns >0 )
                if ((randomObject == "Ladder") || (randomObject == "Bridge"))
                {
                    Console.WriteLine("do you want to jump or duck?");
                    string duck = "duck";
                    string jumpDuckSelect = Console.ReadLine();
                    if (jumpDuckSelect == duck.ToLower())
                    {
                        Console.WriteLine("A sucsessfull jump");
                    }
                    else
                    {
                        runner.ReduceStam();
                        Console.WriteLine($"{runner} Stamina: You fell, -1 to Stamina");
                    }
                }
                else
                {
                    Console.WriteLine("do you want to jump or duck?");
                    string jump = "jump";
                    string jumpDuckSelect = Console.ReadLine();
                    if (jumpDuckSelect == jump.ToLower())
                    {
                       Console.WriteLine("A sucsessfull jump");
                    }
                    else
                    {
                        runner.ReduceStam();
                        Console.WriteLine($"{runner} Stamina: You fell, -1 to Stamina");
                    }
                }
        }
    }
}
