using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ConverterConsole.Tests
{
    public class Conver_P_10Tests
    {
        [Theory]
        [InlineData(2590, "A1E", 16)]
        [InlineData(15, "F", 16)]
        [InlineData(463, "717", 8)]
        [InlineData(26, "32", 8)]
        [InlineData(10, "1010", 2)]
        [InlineData(15, "1111", 2)]
        [InlineData(0, "0", 5)]
        public void CanConvertInteger(double expected, string pNumber, int p)
        {
            //arrange
            //act 
            double convertedResult = Conver_p_10.dval(pNumber, p);
            //assert
            Assert.Equal(expected, convertedResult);
        }

        [Theory]
        [InlineData(174.3125, "AE.5", 16)]
        [InlineData(255.0625, "FF.1", 16)]
        [InlineData(11.625, "13.5", 8)]
        [InlineData(5.375, "5.3", 8)]
        [InlineData(1.5, "1.1", 2)]
        [InlineData(5.25, "101.01", 2)]
        [InlineData(0, "0.00", 5)]
        public void CanConvertFloating(double expected, string pNumber, int p)
        {
            //arrange
            //act 
            double convertedResult = Conver_p_10.dval(pNumber, p);
            //assert
            Assert.Equal(expected, convertedResult);
        }

    }
}
