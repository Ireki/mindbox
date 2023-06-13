namespace ShapeDLL.Test
{
    public class CircleTests
    {
        private readonly double _accuracy = 10e-12;


        [Fact]
        public void IsValidCircle()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0));
            Assert.Throws<ArgumentException>(() => new Circle(-123));

        }

        [Fact]
        public void Area()
        {
            var radius = 123;
            var area = new Circle(radius).GetArea();

            Assert.True(Math.PI * radius * radius - area < _accuracy);
        }

        [Fact]
        public void Perimeter()
        {
            var radius = 123;
            var perimeter = new Circle(radius).GetPerimeter();

            Assert.True(2 * Math.PI * radius - perimeter < _accuracy);
        }

    }
}