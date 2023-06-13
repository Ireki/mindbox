namespace ShapeDLL
{
    public class Triangle : IShape
    {
        public double Side1 { get; }
        public double Side2 { get; }
        public double Side3 { get; }
        public double Accuracy { get; }

        public Triangle(double side1, double side2, double side3, double accuracy = 10e-12)
        {
            IsValidTriangle(side1, side2, side3, accuracy);
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            Accuracy = accuracy;
        }

        private static void IsValidTriangle(double side1, double side2, double side3, double accuracy)
        {
            if (side1 <= 0 ||
                side2 <= 0 ||
                side3 <= 0)
                throw new ArgumentException("The sides of the triangle should be positive.");

            if (accuracy < 0)
                throw new ArgumentException("The accuracy cannot be negative.");

            if (side1 + side2 <= side3 ||
                side2 + side3 <= side1 ||
                side1 + side3 <= side2)
                throw new ArgumentException("Any sum of the two sides of the triangle must be greater than the third side.");
        }

        public virtual double GetArea()
        {
            var semiperimeter = GetPerimeter() / 2;

            return Math.Sqrt(semiperimeter * 
                (semiperimeter - Side1) * 
                (semiperimeter - Side2) * 
                (semiperimeter - Side3));

        }

        public virtual double GetPerimeter() => Side1 + Side2 + Side3;

        public virtual bool IsRightTriangle()
        {
            var legs1 = Side1 < Side2 ? Side1 : Side2;
            var hypotenuse = Side1 > Side2 ? Side1 : Side2;
            var legs2 = hypotenuse < Side3 ? hypotenuse : Side3;
            hypotenuse = hypotenuse > Side3 ? hypotenuse : Side3;

            return Math.Abs(hypotenuse * hypotenuse - legs1 * legs1 - legs2 * legs2) < Accuracy;
        }

    }
}