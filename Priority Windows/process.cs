using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priority_Windows
{
    class process
    {
        public int arrival, burst, priority, start, waiting=0, finish;
        public string name;
        public process(string name,int arrival,int burst,int priority)
        {
            this.name = name;
            this.arrival = arrival;
            this.burst = burst;
            this.priority = priority;
        }
    }
}
