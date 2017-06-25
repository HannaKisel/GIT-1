using System;

namespace checkSeq
{
    class checkSequence
    {
        static void Main(string[] args)
        {
            bool Checking = true;
            while (Checking)
            {
                try
                {
                    Console.Write("Size of your sequence is n = ");
                    String sizeArray = Console.ReadLine();
                    int size = int.Parse(sizeArray);
                    int[] array = new int[size];
                    string stringAr;
                    if (size == 1)
                    {
                        Console.WriteLine("This sequence is not nondecreasing and is't decreasing ");
                        continue;
                    }
                    else
                    {
                        for (int i = 0; i < size; i++)
                        {
                            Console.Write("Enter a[" + (i + 1) + "] = ");
                            stringAr = Console.ReadLine();
                            array[i] = int.Parse(stringAr);
                        }
                        Console.Write("Your sequence is : ");
                        for (int i = 0; i < size; i++)
                        {
                            Console.Write(array[i] + " ");
                        }
                        int chek = 0;
                        for (int i = 1; i < size; i++)
                        {
                            if (array[i] >= array[i - 1])
                            {
                                chek++;
                            }
                        }
                        if (chek == 0)
                        {
                            Console.WriteLine("\n This sequence is decreasing ");
                        }
                        else
                        { Console.WriteLine("\n This sequence is nondecreasing "); }
                        Console.ReadKey();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("It is not a number. Try again");
                    continue;
                }
                Checking = false;
            }
        }
    }
}