using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeadandoFeladat2021.MainPrograms
{
    public class LeapYear
    {
        

        public bool checkLeapYear (int year)
        {
            //Nem kezeli a metódus eredetileg a 0 vagy annál kisebb számok megadásának az esetét.
            if (year <= 0)           
                return false;           
            else if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))  //Nincs értelme a (year % 2 == 0) feltételnek, mert a szökőévek 4 évente vannak, ezért a 2-t cserélem 4-re.
                return true;
            else
                return false;
        }

    }
}
