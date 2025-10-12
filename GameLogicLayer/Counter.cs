using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinaLaPalabraRicardoHernandez
{
    internal class Counter
    {
        public static int tryNumber =1;
        public static int winNumber = 1;

        public static int WinNumber { get => winNumber; }

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


        public static void AddWin()
        {

            winNumber++;

        }

        public static void resetWin()
        {
            winNumber = 1;
        }

    }
}
