using System;

namespace StringDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] word = new int[5];
            ModifyString(word);
            Console.WriteLine(Convert.ToString(word[0]));

            Console.ReadKey();
        }

        static void ModifyString(int[] word)
        {
            word[0] = 1;
        }
    }
}
