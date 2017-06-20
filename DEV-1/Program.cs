// First Task program in C#.
using System;
namespace FirstTask
{
    class Task
    {
        static void Main()
        {
            
            for (int i = 0; i < 101; i++)
            {
                if (i % 3 == 0)
                {
                    int number;
                    number = i / 3;
                    Console.Write("3 * "+ number );                                  
                }
                else
                {
                    Console.Write(i);
                }
                Console.Write(" ; ");

            }

            Console.Write("\n");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}