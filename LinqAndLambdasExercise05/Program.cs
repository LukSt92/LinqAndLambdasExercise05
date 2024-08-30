using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambdasExercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            var sports = new ManualSportSequence();
            foreach (var sport in sports)
                Console.WriteLine(sport);
        }
    }
}
