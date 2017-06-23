using System;

namespace SequenceFib
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please, enter number ");
            String inputString = Console.ReadLine();
            int numbFibonacci = int.Parse(inputString);
            if (numbFibonacci < 0)
            {
                Console.WriteLine("I can't check this number");
            }
            int[] array = new int[numbFibonacci + 3];
            array[0] = 0;
            array[1] = 1;
            bool check = false;
            Console.WriteLine(" Fibonacci sequence :  ");
            for (int i = 0; i <= numbFibonacci; i++)
            {
                array[i + 2] = array[i] + array[i + 1];
                Console.Write(array[i] + " ");
                if (numbFibonacci == array[i])
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("This's  Fibonacci number = " + numbFibonacci);
                    check = true;
                    break;
                }
            }
            if (check == false)
            {
                Console.WriteLine("\nThis is't Fibonacci number ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("For exit press any button");
            Console.ReadKey();
        }
    }
}
