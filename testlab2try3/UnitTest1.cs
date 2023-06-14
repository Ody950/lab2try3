
using ATM;
using System.Security.Principal;
using Xunit;

namespace ATMtest
{
    public class ProgramTest
    {
        [Fact]
        public void TestViewBalance()
        {
            // Arrange
            decimal TestBalance1 = Program.Balance;
            decimal actual;



            // Act
            actual = Program.ViewBalance();

            // Assert
            Assert.Equal(TestBalance1, actual);
        }


        [Theory]
        [InlineData(-50)]
        [InlineData(200)]
        [InlineData(50)]
        public void TestWithDraw(decimal amount)
        {
            // Arrange
            decimal TestBalance2 = 100;
            Program.Balance = TestBalance2;

            // Act
            decimal result = Program.WithDraw(amount);

            // Assert
            if (amount < 0)
            {
                Assert.Equal(TestBalance2, result);

            }
            else if (TestBalance2 < amount)
            {
                Assert.Equal(TestBalance2, result);

            }
            else
            {
                Assert.Equal(TestBalance2 - amount, result);

            }
        }

        [Theory]
        [InlineData(50)]
        [InlineData(-40)]
        public void TestDeposit(decimal amount2)
        {
            // Arrange
            decimal TestBalance3 = 100;
            Program.Balance = TestBalance3;

            // Act
            decimal result2 = Program.Deposit(amount2);

            if (amount2 < 0)
            {
                Assert.Equal(TestBalance3, result2);

            }
            else
            {
                Assert.Equal(TestBalance3 + amount2, result2);
            }
        }
    }
}



