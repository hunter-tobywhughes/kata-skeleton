using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void FunctionShouldReturnTheNumberPassedToIt()
        {
            // Arrange 
            int expectedNumber = 5;
            // Act
            int returnedNumber = Kata.ExampleFunction(expectedNumber);
            // Assert
            Assert.AreEqual(returnedNumber, expectedNumber); 
        }
    }
}