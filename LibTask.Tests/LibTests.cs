using Xunit.Abstractions;
using Xunit.Sdk;

namespace LibTask.Tests
{
    public class LibTests
    {
        [Fact]
        public void ListSquareTest()
        {
            List<Figure> figures = new List<Figure>
            {
                new Circle(10),
                new Triangle(4,5,6),
                new Circle(5)
            };

            foreach (Figure f in figures)
            {
                Console.WriteLine(f.GetType().Name + " " + f.GetSquare());
            }
        }

        [Fact]
        public void TriangleSquare_4_3_5_eq_6_Test()
        {
            Triangle triangle = new Triangle(4, 3, 5);
            Assert.True(triangle.GetSquare() == 6);
        }

        [Fact]
        public void Triangle_3_4_5_isRight_Test()
        {
            Triangle triangle = new Triangle(4, 3, 5);
            Assert.True(triangle.IsRight());
        }

        [Fact]
        public void Triangle_3_3_5_isNitRight_Test()
        {
            Triangle triangle = new Triangle(3, 3, 5);
            Assert.True(triangle.IsRight() == false);
        }

        [Fact]
        public void ExistenceTest()
        {
            Triangle triangle = new Triangle(2, 3, 2);
        }

        [Fact]
        public void NonExistenceTest()
        {
            Action action = () =>
            {
                Triangle triangle = new Triangle(15, 3, 2);
            };

            Assert.Throws<TriangleExistenceException>(action);
        } 
    }
}