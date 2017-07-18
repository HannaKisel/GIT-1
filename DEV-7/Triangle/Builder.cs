using System;

namespace Triangle
{
    class Builder
    {
        const double EPS = double.Epsilon;

        public Triangle Build(Sides sides)
        {
            Type type = DetermineType(sides);
            switch (type)
            {
                case Type.SIMPLETRIANGLE:
                    return new SimpleTriangle(sides);
                case Type.EQUILATERALORTRIANGLE:
                    return new EquilateralorTriangle(sides);
                case Type.ISOSCALESTRIANGLE:
                    return new IsoscalesTriangle(sides);
                default:
                    throw new InvalidOperationException();
            }
        }

        public Type DetermineType(Sides sides)
        {
            Type type = Type.SIMPLETRIANGLE;
            if (Math.Abs(sides.sideA - sides.sideB) < EPS || Math.Abs(sides.sideA - sides.sideC) < EPS || Math.Abs(sides.sideC - sides.sideB) < EPS)
            {
                type = Type.ISOSCALESTRIANGLE;
            }
            else if (Math.Abs(sides.sideA - sides.sideB) < EPS && Math.Abs(sides.sideB - sides.sideC) < EPS)
            {
                type = Type.EQUILATERALORTRIANGLE;
            }
            return type;
        }
    }
}