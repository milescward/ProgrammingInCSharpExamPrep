using System;
using ImplementDataAccess.Extra;
using Xunit;

namespace ImplementDataAccess.Tests
{
    public class FuncsAndActionsTest
    {
        [Fact]
        public void TestSquared()
        {
            //Arrange
            Func<int, int> squared = x => x * x;
            int x = 3;
            //Act
            int expected = 9;
            int actual = squared(x);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
