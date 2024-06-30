using System;
using System.Collections.Generic;

namespace Common_Elements
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 4, 5, 6, 7, 8 };

            int[] commonElements = CommonElements(array1, array2);

            Console.WriteLine("Common elements: " + string.Join(", ", commonElements));
        }

        public static int[] CommonElements(int[] array1, int[] array2)
        {
            List<int> common = new List<int>();

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        if (!common.Contains(array1[i]))
                        {
                            common.Add(array1[i]);
                        }
                        break;
                    }
                }
            }

            return common.ToArray();
        }
    }
}
