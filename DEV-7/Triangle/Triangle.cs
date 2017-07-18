namespace Triangle
{
    enum Type
    {
        SIMPLETRIANGLE,
        EQUILATERALORTRIANGLE,
        ISOSCALESTRIANGLE
    }

    abstract class Triangle
    {
        public Sides Sides
        {
            get;
        }

        public Triangle(Sides sides)
        {
            Sides = sides;
        }
        public abstract string GetTypeOfTriangle();// астрактный метод - мы его не описывае , когда переопределяем в наследниках мы его описываем
    }
}