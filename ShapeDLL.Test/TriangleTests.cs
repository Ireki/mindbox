namespace ShapeDLL.Test
{
    public class TriangleTests
    {

        private readonly double _accuracy = 10e-12;

        [Fact]
        public void IsValidTriangle()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(0, 12, 13));
            Assert.Throws<ArgumentException>(() => new Triangle(12, 13, 14, -1));
            Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 123));
        }

        [Fact]
        public void Area()
        {
            Assert.True(72.3079 - new Triangle(12, 13, 14).GetArea() < _accuracy);
        }

        [Fact]
        public void Perimeter()
        {
            var a = 12; 
            var b = 13; 
            var c = 14;

            Assert.True(a + b + c - new Triangle(a, b, c).GetPerimeter() < _accuracy);
        }

        [Fact]
        public void IsNotRightTriangle()
        {
            Assert.False(new Triangle(123, 123, 123).IsRightTriangle());
        }

        [Fact]
        public void IsRightTriangle() 
        {

            Assert.True(new Triangle(3, 4, 5).IsRightTriangle());
        }

    }
}
