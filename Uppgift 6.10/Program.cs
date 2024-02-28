
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        Console.WriteLine($"Det finns {AntalTalIText(input)} stycken tal i meningen");
    }

    static int AntalTalIText(string input)
    {
        int gånger = 0;
        string[] array = input.Split(' ');
        for (int i = 0; i < array.Length; i++)
        {
            try
            {
                double x = double.Parse(array[i]);
                gånger++;
            }
            catch 
            {
                
            }
        }
        return gånger;
    }
}