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
        /// <summary>
        /// adda 1 to the try counter
        /// </summary>
        public static void AddTry()
        {

            tryNumber++;
            
        }
        /// <summary>
        /// resets the try counter to 1
        /// </summary>
        public static void ResetCounter()
        {
            tryNumber = 1;
        }


    }
}
