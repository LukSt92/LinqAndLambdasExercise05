using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambdasExercise05
{
    class PowersOfTwo : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i <= Math.Round(Math.Log(int.MaxValue, 2)); i++)
                yield return (int)Math.Pow(2, i);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
