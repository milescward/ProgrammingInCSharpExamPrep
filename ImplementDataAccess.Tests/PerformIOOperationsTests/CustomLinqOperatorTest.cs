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
            var query = nums.Filter(n => n % 2 == 0);

            //Act
            int[] actual = query.ToArray();
            int[] expected = {0, 2, 4, 6, 8 };

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
