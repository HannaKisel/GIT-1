namespace Triangle
{
    class EquilateralorTriangle : Triangle
    {
        const string EQUILATERALOR = "This is Equilateralor Triangle ";

        public EquilateralorTriangle(Sides sides) : base(sides) { }

        public override string GetTypeOfTriangle()
        {
            return EQUILATERALOR;
        }
    }
}