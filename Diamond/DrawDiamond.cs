using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    public class DrawDiamond
    {
        public static int LetterPos(char letter)
        {
            return (int)letter - 64;
        }

        public static int CalcPadding(char DLetter, char RLetter)
        {
            //return  LetterPos(DLetter) - LetterPos(RLetter);
            return (int)(DLetter) - (int)RLetter;
        }
        //Practice: Calculate the number of spaces in between
        public static int CalcSpacing(char RLetter)
        {
            if (RLetter == 'A')
            {
                return 0;
            }
            return LetterPos(RLetter) * 2 - 3;
        }

        //Practice: A function that takes number of spaces and builds the space string
        // 2 -> "  "
        // 5 -> "     "
        // 0 -> ""
        //Fucntion name is MakeSpaces

        public static string MakeSpaces(int num)
        {
            if (num == 0)
            {
                return "";
            }
            string result = "";
            for(int i = 1; i <= num; i++)
            {
                result = result + " ";
            }
            return result;
        }


        public static string OneLine(char DLetter, char RLetter)
        {
            //Create a string variable called result
            string result = "";

            //Call CalcPadding

            //Call MakeSpaces using the padding and add that to result
            //Hint: Save the result here in a variablem maybe called padding,
            //because we need it here and at the very end in this method.

            //Add on the letter

            //Call Calc Spacing for the inner spacing

            //Call MakeSpaces using the inner spacing and add to result

            //Add on the letter again

            //Use the MakeSpace string to add the end spaces

            return "";
        }
    }
}
