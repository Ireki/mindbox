namespace ShapeDLL
{
    public class Circle : IShape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            IsValidShape(radius);
            Radius = radius;
        }

        private static void IsValidShape(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("The radius of the circle cannot be negative or equal to zero.");
        }

        public virtual double GetArea() => Math.PI * Radius * Radius;

        public virtual double GetPerimeter() => 2 * Math.PI * Radius;
    }
}
