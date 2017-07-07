using System;

namespace Triangle
{
    class Controller
    {
        const string UNCORRECTNUMB = "This numbers are uncorrect for tringle. Try again";

        public bool control(double sideA, double sideB, double sideC)
        {
            bool checking = true;
            if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
            {
                checking = true;
            }
            else
            {
                Console.WriteLine(UNCORRECTNUMB);
                checking = false;
            }
            return checking;
        }
    }
}