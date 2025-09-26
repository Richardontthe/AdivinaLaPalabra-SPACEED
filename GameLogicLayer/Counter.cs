using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinaLaPalabraRicardoHernandez
{
    internal class Counter
    {
        private static int tryNumber =1;

        public static int TryNumber { get => tryNumber;  }

        public static void AddTry()
        {
            if (tryNumber < 6)
                tryNumber++;
            
        }

        public static void ResetCounter()
        {
            tryNumber = 1;
        }


    }
}
