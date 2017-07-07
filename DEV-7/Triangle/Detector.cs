using System;

namespace Triangle
{
    class Detector
    {
        const string TRINGLEISOSCELLES = " This tringle is isoscelles";
        const string EQUILATERAL = " This tringle is equilateral";
        const string SIMPLE = " This tringle is 'simple'";

        public void detect(double sideA, double sideB, double sideC)
        {
            if (sideA == sideB || sideA == sideC || sideC == sideB)
            {
                Console.WriteLine(TRINGLEISOSCELLES);
            }
            else if (sideA == sideB && sideB == sideC)
            {
                Console.WriteLine(EQUILATERAL);
            }
            else
            {
                Console.WriteLine(SIMPLE);
            }
        }
    }
}