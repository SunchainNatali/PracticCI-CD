using System;
using Xunit;
using PractikaXUnit;

namespace PractikaXUnit
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 2, 3, 3)]
        [InlineData(0, 5, 5, 5)]
        [InlineData(-3, -5, -8, -8)]
        [InlineData(4.99, 5.01, 10.00, 10)]
        [InlineData(-1,1,0,0)]
        [InlineData(-2, 2, 7, 3.5)]
        [InlineData(0, 7, 5, 6)]
        [InlineData(-10.1, -5.99, -8.01, -12.05)]
        [InlineData(4.9, 5.1, 10.09, 10.045)]
        [InlineData(-1000, 1000, 0, 0)]
        [InlineData(299, 301, -299, 150.5)]
        [InlineData(1.999, 5.0001, 5.0099, 6.0045)]
        [InlineData(-3.01, -5.099, -8.0001, -8.054549999999999)]
        [InlineData(4.999, 5.00001, 10.0001, 9.999554999999999)]
        [InlineData(-9999999, 0, 9999999, 0)]
        [InlineData(-9999.99, 1111.111, 999999.00001, 495555.060505)]
        [InlineData(-0.1, 0.01, 1.001, 0.45549999999999996)]
        [InlineData(-10.09, -5.099, -8.01, -11.599499999999999)]
        [InlineData(4.91, 5.11, 10.099, 10.0595)]
        [InlineData(-1000.0, 1000.1, 0.01, 0.055000000000011366)]

        public void PossibleGetArea(double a, double b, double d,  double expected)
        {

            double actual = Triangle.GetPerimetrTriangle(a, b, d);
            Assert.Equal(expected, actual);

        }
    }
}
