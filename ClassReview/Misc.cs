using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassReview
{
    //Change internal to public
    public class Misc
    {
        public static bool CheckRange(int x)
        {
            //Return true is number is in range 10-20 inclusive.
            //Else return false
            // Tests: 9, 10, 15, 20, 21
            // boundaries and 1 middle
            if(x >= 10 && x <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Let's write a method that take an integer
        // and returns:
        //   -1 if int integer is negative
        //    0 if the integer is 0
        //    1 if the integer is positive
        // What should we test?
        // We will test -2, -1, 0, 1 , 2

        public static int PosNeg(int x)
        {
            //First attempt
            if( x < 0)
            {
                return -1;
            }
            else if (x > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

    }
}
