namespace Triangle
{
    class SimpleTriangle : Triangle
    {
        const string SIMPLE = "This is Simple Triangle ";

        public SimpleTriangle(Sides sides) : base(sides) { }

        public override string GetTypeOfTriangle()
        {
            return SIMPLE;
        }
    }
}