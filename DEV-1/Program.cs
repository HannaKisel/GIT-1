using System;

namespace first_task_with_string
{
    class Program
    {
        static void Main()
        {
            for (int i = 0; i < 101; i++)
            {
                string posl = i.ToString();
                if (i % 3 == 0)
                {
                    posl = " 3* " + i / 3;
                }
                System.Console.Write(posl + " ; ");
            }
            System.Console.WriteLine(" ");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
