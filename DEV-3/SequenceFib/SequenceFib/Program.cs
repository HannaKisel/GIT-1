using System;

namespace SequenceFib
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, enter number");
            String inputString = Console.ReadLine();
            int numbFibonacci = int.Parse(inputString);
            if (numbFibonacci < 0)
            {
                Console.WriteLine("I can't check this number");

            }
            Console.WriteLine("For exit press any button");
            Console.ReadKey();
        }
    }

}
