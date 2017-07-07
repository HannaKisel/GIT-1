using System;

namespace Triangle
{
    class Program
    {
        const string SIDES = "Sides of the triangle: ";
        const string EXIT = "For exit press any button";
        const string ERROR = "It is not a number. Try again";

        static void Main(string[] args)
        {
            bool duration = true;
            while (duration)
            {
                try
                {
                    Inputer input = new Inputer();
                    double sideA = input.input();
                    double sideB = input.input();
                    double sideC = input.input();
                    Console.WriteLine(SIDES + sideA + "; " + sideB + "; " + sideC + ".");
                    Controller control = new Controller();
                    if (control.control(sideA, sideB, sideC) == true)
                    {
                        Detector detect = new Detector();
                        detect.detect(sideA, sideB, sideC);
                    }
                    else
                    {
                        continue;
                    }
                    Console.WriteLine(EXIT);
                    Console.ReadKey();
                }
                catch (FormatException)
                {
                    Console.WriteLine(ERROR);
                    continue;
                }
                duration = false;
            }
        }
    }
}