using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        //Fact is an attribute that indicates a unit test
        //xunit will only invoke methods with [fact] before it
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            //act
            var result = book.GetStatistics();

            //assert
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
            Assert.Equal('B', result.Letter);
        }

        [Fact]

        public void GradesOutsideRangeShouldNotBeAdded()
        {
            var book = new Book("");
            
            book.AddGrade(105);
            var result = book.GetStatistics();

            Assert.NotEqual(105, result.Average);
        }
    }
}
