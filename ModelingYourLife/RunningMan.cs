using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelingYourLife
{
    enum State
    {
        Standing, Fallen
    }
    class RunningMan
    {
        private int stam;
        public string runnerName;
        public State current = State.Standing;

        public RunningMan(string _runnerName)
        {
            runnerName = _runnerName;
            stam = 3;
        }
        public void ReduceStam()
        {
            if (stam <= 0)
            {
                Console.WriteLine($"{ runnerName} Is Down for the count");
                stam = 0;
                current = State.Fallen;
            }
            else
            {
                stam -= 1;
            }
        }
    }
}
