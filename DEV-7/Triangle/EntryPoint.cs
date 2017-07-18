using System;

namespace Triangle
{
    class EntryPoint
    {
        static void Main()
        {
            const string ERROR = "It is not a number. Try again";
            const string NOTEXIST = " This triangle doesn't exist. Try again";

            bool duration = true;
            while (duration)
            {
                try
                {
                    Console.WriteLine("Enter sides");
                    Inputer inputer = new Inputer();
                    Sides sides = new Sides();
                    sides.sideA = inputer.Input();
                    sides.sideB = inputer.Input();
                    sides.sideC = inputer.Input();
                    Controller controller = new Controller();
                    if (controller.CheckForExistance(sides))
                    {
                        Builder builder = new Builder();
                        Triangle triangle = builder.Build(sides);
                        Console.WriteLine(triangle.GetTypeOfTriangle());
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine(NOTEXIST);
                        continue;
                    }
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