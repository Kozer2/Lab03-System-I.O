using System;
using Xunit;
using Lab03_System_I.O; 

namespace Lab03_SystemIOTests
{
    public class UnitTest1
    {
        [Fact]
        public void Challenge1_test_for_correct_int()
        {
            // arrange
            string testString = ("1 2 3");
            // act
            int result = Program.Challenge1(testString);
            // assert
            Assert.Equal(6, result);

        } // end Challenge1_test_for_correct_int

        [Fact]
        public void Challenge1_test_for_correct_int_with_more_than_3_numbers()
        {
            // arrange
            string testString = ("1 2 3 4 5 6 7 8");
            // act
            int result = Program.Challenge1(testString);
            // assert
            Assert.Equal(6, result);

        } // end Challenge1_test_for_correct_int_with_more_than_3_numbers

        [Fact]
        public void Challenge1_test_for_correct_int_with_less_than_3_numbers()
        {
            // arrange
            string testString = ("4 5");
            // act
            int result = Program.Challenge1(testString);
            // assert
            Assert.Equal(0, result);

        } // end Challenge1_test_for_correct_int_with_less_than_3_numbers

        [Fact]
        public void Challenge1_test_for_correct_int_with_negative_numbers()
        {
            // arrange
            string testString = ("-4 -5 -10");
            // act
            int result = Program.Challenge1(testString);
            // assert
            Assert.Equal(200, result);

        } // end Challenge1_test_for_correct_int_with_negative_numbers


        [Fact]
        public void Challenge1_test_for_correct_return_with_non_numbers()
        {
            // arrange
            string testString = ("r d t");
            // act
            int result = Program.Challenge1(testString);
            // assert
            Assert.Equal(1, result);

        } // end Challenge1_test_for_correct_return_with_non_numbers


        [Fact]
        public void Challenge2_test_for_correct_return_with_different_ranges()
        {
            // arrange
            int[] testArr = new int[4] { 4, 8, 15, 16 };
            int[] testArr2 = new int[8] { 2, 4, 6, 8, 10, 12, 16, 18 };
            int[] testArr3 = new int[6] { 0, 0, 0, 0, 0, 0 };


            // act
            int result = Program.Challenge2(testArr);
            int result2 = Program.Challenge2(testArr2);
            int result3 = Program.Challenge2(testArr3);

            // assert
            Assert.Equal(10, result);
            Assert.Equal(9, result2);
            Assert.Equal(0, result3);

        } // end Challenge2_test_for_correct_return_with_different_ranges

        [Fact]
        public void Challenge2_test_for_exception_return_incorrect_ranges()
        {
            // arrange
            int[] testArr = new int[1] { 1 };
            int[] testArr2 = new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
    
            // assert
            var ex = Assert.Throws<IndexOutOfRangeException> (() =>
            {
                // act
                int result = Program.Challenge2(testArr);
            });
            var ex2 = Assert.Throws<IndexOutOfRangeException>(() =>
            {
                // act
                int result = Program.Challenge2(testArr2);
            });

            // assert
            Assert.Equal("Incorrect array length", ex.Message);
            Assert.Equal("Incorrect array length", ex2.Message);

        } // end Challenge2_test_for_exception_return_incorrect_ranges

    }
}
