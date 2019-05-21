import unittest
import kata

class TestStringMethods(unittest.TestCase):

    # Function name MUST start with 'test' for it to be run
    def test_example_function_returns_number_passed_to_it(self):
        # Arrange
        expected_number = 5
        # Act
        returned_number = kata.example_function(expected_number)
        # Assert
        self.assertEqual(returned_number, expected_number)

if __name__ == '__main__':
    unittest.main()