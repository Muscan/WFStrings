using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Functions
    {

        public static string ExtractNumbers(string text)
        {
            /* It is considered a text in which the space is the only separator.
         Create a program that displays the numbers that appear in the text, separated by a space.
        Ex: Pt. "John has 2 cars and 233 meter walked today, will be displayed 7 223" */

            string newWordWithNumbers = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsDigit(text[i]) == true)
                //If the first char is a number
                {
                    newWordWithNumbers += text[i];
                }
                if (text[i] == ' ')
                {
                    newWordWithNumbers += " ";
                }
            }
            return newWordWithNumbers;
            //Console.WriteLine($"Numbers are {newWordWithNumbers}");
        }

        public static int NrCharTxt(String text, char characterWeAreSearchingFor)
        {
            /*A text of up to 255 characters is considered.
            Create a program that displays:
            a.The number of occurrences of a letter in the text. 
            b.How many vowels appear in the read text
            
            a.2; b.8; c.2 */
            int countNrOfAppearanceInText = 0;

            for (int i = 0; i < text.Length; i++)
            {

                if (text[i] == characterWeAreSearchingFor)
                {

                    countNrOfAppearanceInText++;
                }
            }
            return countNrOfAppearanceInText;
        }

        public static bool IsVowel(char x)
        {   //Nr. of vowels

            string vowels = "AEIOUaeiou";

            for (int i = 0; i < vowels.Length; i++)
            {
                if (vowels[i] == x)
                {
                    return true;
                }
            }
            return false;

        }
    }
}
