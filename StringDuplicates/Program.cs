using System;

namespace StringDuplicates
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] word = new int[5];
            ModifyString(word);
            Console.WriteLine(Convert.ToString(word[0]));
            Console.ReadKey();
        }

        private static void ModifyString(int[] word)
        {
            word[0] = 1;
        }
    }
}