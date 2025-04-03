using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeadandoFeladat2021.MainPrograms
{
    public class Mathemathics
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Max(int a, int b)
        {
            return (a > b) ? a : b;  //Egyenlőség jelzésére nincs semmilyen megoldás implementálva.
        }

        public IEnumerable<int> GetOddNumbers(int limit)
        {
            for (var i = 1; i <= limit; i++)  //For ciklus indító értékét 1-re érdemes állítani, hogy az 1-et is visszakapjuk, mivel az is páratlan érték.
                if (i % 2 != 0)
                    yield return i;
        }
    }
}

