using System;

namespace checkSeq
{
    class Inputer
    {
        public int[] ConsoleInput()
        {
            Console.Write("Enter array from console = ");
            string[] stringArray = Console.ReadLine().Split(new char[] { ',', ';' });
            int[] array = Parser(stringArray);
            return array;
        }

        public int[] InputComLine(string[] comLineArgs)
        {
            int[] array = Parser(comLineArgs);
            return array;
        }

        public int[] Parser(string[] posl)
        {
            int[] arrayFromString = new int[posl.Length];
            for (int i = 0; i < posl.Length; i++)
            {
                arrayFromString[i] = int.Parse(posl[i]);
            }
            return arrayFromString;
        }
    }
}