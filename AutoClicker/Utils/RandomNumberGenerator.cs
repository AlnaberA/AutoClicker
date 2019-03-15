using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClicker.Utils
{
    class RandomNumberGenerator
    {
        public int RandomNumber(int startNumber, int endNumber)
        {
            Random rnd = new Random();
            int number = rnd.Next(startNumber, endNumber); // creates a number between start and end
            return number;
        }
    }
}
