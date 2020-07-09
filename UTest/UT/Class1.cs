using System;
using Xunit;

namespace Tests
{
    /// <summary>
    /// Тестирование метода GetCommission
    /// </summary>
    public class Test_ExchangeProvider
    {
        [Fact]
        public void GetCommission_4_0()
        {
            // Arrange
            ConsoleApp.ExchangeProvider ExchangeProvider = new ConsoleApp.ExchangeProvider();

            // Act
            var result = ExchangeProvider.GetCommission(1000-1);

            // Assert
            Assert.Equal(4.0, result);
        }

        [Fact]
        public void GetCommission_3_0()
        {
            // Arrange
            ConsoleApp.ExchangeProvider ExchangeProvider = new ConsoleApp.ExchangeProvider();

            // Act
            var result = ExchangeProvider.GetCommission(10000-1);

            // Assert
            Assert.Equal(3.0, result);
        }

        [Fact]
        public void IGetCommission_2_0()
        {
            // Arrange
            ConsoleApp.ExchangeProvider ExchangeProvider = new ConsoleApp.ExchangeProvider();

            // Act
            var result = ExchangeProvider.GetCommission(50000-1);

            // Assert
            Assert.Equal(2.0, result);
        }

        [Fact]
        public void GetCommission_1_0()
        {
            // Arrange
            ConsoleApp.ExchangeProvider ExchangeProvider = new ConsoleApp.ExchangeProvider();

            // Act
            var result = ExchangeProvider.GetCommission(100000-1);

            // Assert
            Assert.Equal(1.0, result);
        }

        [Fact]
        public void GetCommission_0_3()
        {
            // Arrange
            ConsoleApp.ExchangeProvider ExchangeProvider = new ConsoleApp.ExchangeProvider();

            // Act
            var result = ExchangeProvider.GetCommission(100000+1);

            // Assert
            Assert.Equal(0.3, result);
        }
    }

    /// <summary>
    /// Тестирование метода Exchange
    /// </summary>
    public class Test_Exchange
    {
        [Fact]
        public void Exchange_14_927()
        {
            // Arrange
            ConsoleApp.ExchangeProvider ExchangeProvider = new ConsoleApp.ExchangeProvider();

            // Act
            var result = Math.Round(ExchangeProvider.Exchange(1000-1),3);

            // Assert
            Assert.Equal(14.927, result);
        }

        [Fact]
        public void Exchange_150_958()
        {
            // Arrange
            ConsoleApp.ExchangeProvider ExchangeProvider = new ConsoleApp.ExchangeProvider();

            // Act
            var result = Math.Round(ExchangeProvider.Exchange(10000-1),3);

            // Assert
            Assert.Equal(150.958, result);
        }
    }
}
