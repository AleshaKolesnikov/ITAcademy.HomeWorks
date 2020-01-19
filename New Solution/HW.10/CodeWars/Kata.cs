using System;
using System.Collections.Generic;
using System.Text;

namespace HW._10.CodeWars
{
    //Link - https://www.codewars.com/kata/563089b9b7be03472d00002b

    //Define a method/function that removes from a given array of integers all the values contained in a second array.
    public class Kata
    {
        public static int[] Remove(int[] integerList, int[] valuesList)
        {
            int comparedLength = integerList.Length;

                for (int i = 0; i < integerList.Length; i++)
                {
                    for (int j = 0; j < valuesList.Length; j++)
                    {
                        if (integerList[i].Equals(valuesList[j]))
                        {
                            comparedLength--;
                            integerList[i] = 0;
                        }
                    }
                }

            int[] result = new int[comparedLength];
            int counter = 0;

                for (int i = 0; i < integerList.Length; i++)
                    {
                        if (integerList[i] != 0)
                        {
                            result[counter] = integerList[i];
                            counter++;
                        }
                    }
            return result;
        }
    }
}
