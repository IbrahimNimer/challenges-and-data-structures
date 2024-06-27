using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] inputArray = { 16, 8, 31, 17, 15, 23, 17, 8 };
        int[] duplicates = FindDuplicates(inputArray);
        
        Console.WriteLine("Duplicates: ");
        foreach (var duplicate in duplicates)
        {
            Console.Write(duplicate + " ");
        }
        Console.WriteLine();
    }

    static int[] FindDuplicates(int[] array)
    {
        List<int> duplicates = new List<int>();

        
        for (int i = 0; i < array.Length; i++)
        {
            int current = array[i];
            
            if (duplicates.Contains(current))
            {
                continue; 
            }
           
            for (int j = i + 1; j < array.Length; j++)
            {
                if (current == array[j] && !duplicates.Contains(current))
                {
                    duplicates.Add(current); 
                    break; 
                }
            }
        }

        return duplicates.ToArray();
    }
}
