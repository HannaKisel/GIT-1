using System;

namespace checkSeq
{
    class Outputer
    {
        public void Output(int[] array)
        {
            Console.Write("Your sequence is : ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}