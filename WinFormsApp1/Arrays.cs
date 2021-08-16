using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Arrays
    {
        //Function which sorts a specific element iterating through the whole array

        public static void DirectSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int aux = array[i];
                        array[i] = array[j];
                        array[j] = aux;
                    }
                }
            }

        }
        public static string ConvertInputIntToOutputString(int[] array)
        {
            string intToStringOneByOne = "";
            for(int i=0; i<array.Length;i++)
            {
                intToStringOneByOne += Convert.ToString(array[i]) + " ";
            }
            return intToStringOneByOne;
        }
    }
}
