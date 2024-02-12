using System;


namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] nRandArray = new int[5];
            nRandArray[0] = rnd.Next(0, 5);
            int i = 1;
            do
            {
                bool blt = true;
                int N = rnd.Next(0, 5);
                for (int j = 0; j != i; j++)
                {
                    if (nRandArray[j] == N) { blt = false; break; }
                }
                if (blt) { nRandArray[i] = N; i++; }
            } while (i != 5);

            for (i = 0; i != 5; i++)
            {
                Console.WriteLine(i + "\t" + nRandArray[i]);
            }

        }
    }
}
