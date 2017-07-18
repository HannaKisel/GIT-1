namespace Triangle
{
    class Controller
    {
        public bool CheckForExistance(Sides sides)
        {
            bool checking = true;
            if (sides.sideA + sides.sideB <= sides.sideC && sides.sideA + sides.sideC <= sides.sideB && sides.sideB + sides.sideC <= sides.sideA)
            {
                checking = false;
            }
            return checking;
        }
    }
}