using Xunit;
using CaseTwo.Models;
using CaseTwo;

namespace CaseTwo.Tests {

    public class LibraryTests
    {
        [Fact]
        public void TestReadBooks()
        {
            // Arrange
            string input = @"Book:
Author: Brian Jensen
Title: Texts from Denmark
Publisher: Gyldendal
Published: 2001
NumberOfPages: 253
Book:
Author: Peter Jensen
Author: Hans Andersen
Title: Stories from abroad
Publisher: Borgen
Published: 2012
NumberOfPages: 156";
            Library library = new Library();

            // Act
            List<Book> result = library.ReadBooks(input);

            // Assert
            Assert.Equal(2, result.Count);
            Assert.Equal("Brian Jensen", result[0].Authors[0]);
            Assert.Equal("Texts from Denmark", result[0].Title);
            Assert.Equal("Gyldendal", result[0].Publisher);
            Assert.Equal(2001, result[0].PublicationYear);
            Assert.Equal(253, result[0].NumberOfPages);
            Assert.Equal("Peter Jensen", result[1].Authors[0]);
            Assert.Equal("Hans Andersen", result[1].Authors[1]);
            Assert.Equal("Stories from abroad", result[1].Title);
            Assert.Equal("Borgen", result[1].Publisher);
            Assert.Equal(2012, result[1].PublicationYear);
            Assert.Equal(156, result[1].NumberOfPages);
        }

        [Fact]
        public void TestFindBooks()
        {
            // Arrange
            string input = @"Book:
Author: Brian Jensen
Title: Texts from Denmark
Publisher: Gyldendal
Published: 2001
NumberOfPages: 253
Book:
Author: Peter Jensen
Author: Hans Andersen
Title: Stories from abroad
Publisher: Borgen
Published: 2012
NumberOfPages: 156";
            Library library = new Library();
            library.ReadBooks(input);

            // Act
            List<Book> result1 = library.FindBooks("*20*");
            List<Book> result2 = library.FindBooks("*20* & *peter*");

            // Assert
            Assert.Equal(2, result1.Count);
            Assert.Equal("Texts from Denmark", result1[0].Title);
            Assert.Equal("Stories from abroad", result1[1].Title);

            Assert.Equal(1, result2.Count);
            Assert.Equal("Stories from abroad", result2[0].Title);
        }
    }

}
