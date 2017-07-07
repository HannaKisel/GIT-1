using System;

namespace Triangle
{
    class Inputer
    {
        const string POSERROR = "It is not a positive number. Try again";
        const string SIDELENGTH = "Enter  the length of the side=";

        public double input()
        {
            double side = 0;
            bool reInput = true;
            while (reInput == true)
            {
                Console.Write(SIDELENGTH);
                side = double.Parse(Console.ReadLine());
                if (side <= 0)
                {
                    Console.WriteLine(POSERROR);
                    continue;
                }
                reInput = false;
            }
            return side;
        }
    }
}