using System;

namespace SequenceFib
{
    class Program
    {
        static void Main()
        {
            bool work = true;
            while (work)
            {
                try
                {
                    Console.Write("Please, enter number ");
                    int numbFibonacci = int.Parse(Console.ReadLine());
                    if (numbFibonacci < 0)
                    {
                        Console.WriteLine("It is a negative number.I can't check this number. Enter again positive number ");
                        continue;
                    }
                    else
                    {
                        int numbFib1 = 1, numbFib2 = 1, numbFibN = 1;
                        bool check = false;
                        for (int i = 0; i < numbFibonacci; i++)
                        {
                            numbFib1 = numbFib2;
                            numbFib2 = numbFibN;
                            numbFibN = numbFib1 + numbFib2;
                            if (numbFibonacci == numbFibN || numbFibonacci == 1)
                            {
                                check = true;
                                break;
                            }
                        }
                        if (check)
                        {
                            Console.WriteLine("This is the Fibonacci number.");
                        }
                        else
                        {
                            Console.WriteLine("This is not the Fibonacci number.");
                        }
                        Console.WriteLine(" ");
                        Console.WriteLine("For exit press any button");
                        Console.ReadKey();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("It is not a number. Try again");
                    continue;
                }
                work = false;
            }
        }
    }
}