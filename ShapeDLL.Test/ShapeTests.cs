namespace ShapeDLL.Test
{
    public class ShapeTests
    {
        [Fact]
        public void CalculateFigureAreaWithoutFigureType()
        {
            IShape shape1 = new Triangle(12, 13, 14);
            IShape shape2 = new Circle(123);
            Assert.True(shape1.GetArea() > 0);
            Assert.True(shape2.GetArea() > 0);
            Assert.True(shape1.GetPerimeter() > 0);
            Assert.True(shape2.GetPerimeter() > 0);
        }
    }
}
