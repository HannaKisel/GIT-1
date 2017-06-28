using System;

namespace checkSeq
{
    class Inputer
    {
        public int[] input()
        {
            Console.Write("Enter array = ");
            string[] stringArray = Console.ReadLine().Split();
            int[] array = new int[stringArray.Length];
            for (int i = 0; i < stringArray.Length; i++)
            {
                array[i] = int.Parse(stringArray[i]);
            }
            return array;
        }
    }
}
