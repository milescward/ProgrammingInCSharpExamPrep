using System;
using System.Collections.Generic;
using System.Linq;
using ImplementDataAccess.QueryAndManipulateDataWLINQ;
using Xunit;

namespace ImplementDataAccess.Tests
{
    public class CustomLinqOperatorTest
    {
        [Fact]
        public void TestCustomFilterOperator()
        {
            //Arrange
            var nums = Enumerable.Range(0, 10);
            var query1 = nums.Filter(n => n % 2 == 0);

            //Act
            int[] expected = { 0, 2, 4, 6, 8 };
            var actual = query1;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RandomTest()
        {
            //Arrange
            var numbers = CustomLinqOperator.Random().Where(n => n > 0.5).Take(10).OrderBy(n => n);

            //Act
            int expected = 10;
            int actual = numbers.Count();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
