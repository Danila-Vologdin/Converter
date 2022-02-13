using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ConverterConsole.Tests
{
    public class HistoryTests
    {
        private readonly History _sut = new History();

        [Theory]
        [InlineData(2, 10, "2", "10")]
        [InlineData(3, 11, "3", "11")]
        [InlineData(4, 12, "4", "12")]
        public void CanAddItem(int p1, int p2, string n1, string n2)
        {
            //arrange
            var expected = new Record(p1, p2, n1, n2);
            //act
            _sut.AddRecord(p1, p2, n1, n2);
            //assert
            Assert.Equal(expected, _sut[0]);

        }

        [Fact]
        public void CanCalculateCount()
        {
            //arrange
            //act
            _sut.AddRecord(3, 11, "3", "11");
            _sut.AddRecord(4, 12, "4", "12");
            _sut.AddRecord(4, 12, "4", "12");
            //assert
            Assert.Equal(3, _sut.Count());
        }

        [Fact]
        public void CanClear()
        {
            //arrange
            _sut.AddRecord(3, 11, "3", "11");
            _sut.AddRecord(4, 12, "4", "12");
            _sut.AddRecord(4, 12, "4", "12");
            //act
            _sut.Clear();
            //assert
            Assert.Equal(0, _sut.Count());
        }
    }
}
