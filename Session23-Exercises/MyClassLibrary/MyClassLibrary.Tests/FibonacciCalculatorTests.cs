using Moq;
using System;
using Xunit;

namespace MyClassLibrary.Tests {
    public class FibonacciCalculatorTests {


        private FibonacciCalculator CreateDefaultSUT() {
            //sut = system under test
            var sut = new FibonacciCalculator();
            return sut;
        }




        [Fact]
        public void N_IsBelowZero_ThrowsArgumentException() {
            //Arrange
            var sut = CreateDefaultSUT();
            var n = -1;

            //Act & Assert
            Assert.Throws<ArgumentException>(() => {
                var actual = sut.FibonacciSeries(n);
            });
        }


        [Fact]
        public void N_IsEqualTo0_Returns0() {
            //Arrange
            var sut = CreateDefaultSUT();
            var n = 0;
            var expected = 0;

            //Act
            var actual = sut.FibonacciSeries(n);

            //Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void N_IsEqualTo1_Returns1() {
            //Arrange
            var sut = CreateDefaultSUT();
            var n = 1;
            var expected = 1;

            //Act
            var actual = sut.FibonacciSeries(n);

            //Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void N_IsBetween2And89_ReturnsFibonacciValue() {
            //Arrange
            var sut = CreateDefaultSUT();
            var n = 8;
            var expected = 21;

            //Act
            var actual = sut.FibonacciSeries(n);

            //Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void N_IsGreaterOrEqualThan90_ThrowsArgumentException() {
            //Arrange
            var sut = CreateDefaultSUT();
            var n = 90;

            //Act & Assert
            Assert.Throws<ArgumentException>(() => {
                var actual = sut.FibonacciSeries(n);
            });
        }


    }
}
