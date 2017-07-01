using System;

namespace checkSeq
{
    class Inputer
    {
        public int[] input(string[] comLineArgs)
        {
            int[] array = null;
            if (comLineArgs.Length == 0)
            {
                Console.Write("Enter array from console = ");
                string[] stringArray = Console.ReadLine().Split(new char[] { ',', ';' });
                array = new int[stringArray.Length];
                for (int i = 0; i < stringArray.Length; i++)
                {
                    array[i] = int.Parse(stringArray[i]);
                }
            }
            else
            {
                array = new int[comLineArgs.Length];
                for (int i = 0; i < comLineArgs.Length; i++)
                {
                    array[i] = int.Parse(comLineArgs[i]);
                }
            }
            return array;
        }
    }
}