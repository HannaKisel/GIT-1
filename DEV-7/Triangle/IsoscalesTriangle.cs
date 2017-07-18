namespace Triangle
{
    class IsoscalesTriangle : Triangle
    {
        const string ISOSCALES = "This is Isoscales Triangle ";

        public IsoscalesTriangle(Sides sides) : base(sides) { }

        public override string GetTypeOfTriangle()
        {
            return ISOSCALES;
        }
    }
}