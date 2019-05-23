using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeCalculator;
using NUnit.Framework;


namespace CalculatorTest
{
    [TestFixture]
    class CalcTests
    {
        [Test]
        public void GetSubtracjtuib_Input330point1and55point6_Returns274point5()
        {
            //Arrange
            double number1 = 330.1;
            double number2 = 55.6;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();
            
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetSubtracjtuib_Input282point0and497point0_ReturnsNag215point0()
        {
            //Arrange
            double number1 = 282.0;
            double number2 = 497.0;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetSubtracjtuib_Input89point2and67point2_ReturnsNag22point()
        {
            //Arrange
            double number1 = 89.2;
            double number2 = 67.2;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);
        
            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetAddition_Input0point1and500point7_Returns500point8()
        {
            //Arrange
            double number1 = 0.1;
            double number2 = 500.7;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetAddition_Input23point3and51point7_Returns75point()
        {
            //Arrange
            double number1 = 23.3;
            double number2 = 51.7;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetAddition_Input38point6and280point9_Returns319point5()
        {
            //Arrange
            double number1 = 38.6;
            double number2 = 280.9;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetMultiplication_Input100point3and2point1_Returns210point63()
        {
            //Arrange
            double number1 = 100.3;
            double number2 = 2.1;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetMultiplication_Input213point4and0point1_Returns2368point74()
        {
            //Arrange
            double number1 = 213.4;
            double number2 = 11.1;

            double expectedResult = Math.Round((number1 * number2),2);

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetMultiplication_Input13point4and0point1_Returns501point()
        {
            //Arrange
            double number1 = 501;
            double number2 = 1;

            double expectedResult = Math.Round((number1 * number2), 2);

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetDivision_Input47point5and1point0_Returns47point5()
        {
            //Arrange
            double number1 = 47.5;
            double number2 = 1.0;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void GetDivision_Input5point5and5point5_Returns1point0()
        {
            //Arrange
            double number1 = 5.5;
            double number2 = 5.5;

            double expectedResult = number1 / number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void GetDivision_Input333point2and33point_Returns47point5()
        {
            //Arrange
            double number1 = 88;
            double number2 = 11;

            double expectedResult = number1 / number2;
            //Math.Round(expectedResult, 2);

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
