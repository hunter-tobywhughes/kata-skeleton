const importedFunctions = require('./index.js');

describe('this testing group', () => {
    test('should call an example function that returns itself', () => {
        // Arrange
        var expectedNumber = 42;
        // Act
        var returnedNumber = importedFunctions.exampleFunction(expectedNumber);
        // Assert
        expect(returnedNumber).toBe(expectedNumber);
    })
});