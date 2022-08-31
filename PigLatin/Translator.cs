using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    //Change internal to public
    public class Translator
    {
        // returns true if it’s a vowel, false if it’s a consonant

        public static bool IsVowel(char ch)
        {
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')     
            {
                return true;
            }
            
            else
            {
                return false;
            }
        }

        public static bool StartsWithVowel(string word)
        {
            bool result = IsVowel(word[0]);
            return result;
        }

        public static int NumberOfCons(string word)
        {
            int index = 0;
            while(index < word.Length && IsVowel(word[index]) == false)
            {
                index++;
            }
            return index;
        }

        //Two methods for piglatining a word

        public static string PigLatinVowels(string word)
        {
            return word + "yay";
        }

        public static string PigLatinCons(string word)
        {
            int cons = NumberOfCons(word);
            string start = word.Substring(0, cons);
            string newword = word + start + "ay";
            newword = newword.Remove(0, cons);
            return newword;
        }

        public static string PigLatinize(string word)
        {
            if (StartsWithVowel(word))
            {
                return PigLatinVowels(word);
            }
            else
            {
                return PigLatinCons(word);
            }
        }
    }
}
