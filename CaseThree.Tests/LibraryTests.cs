using System.Text.Json;
using CaseThree.Models;
using CaseThree.Tests.Models;
using Xunit;

namespace CaseThree.Tests {
    public class LibraryTests
    {
        private readonly Library _library;
        private readonly List<Book> _books;
        private readonly List<BookLocation> _locations;

        public LibraryTests()
        {
            // Read test data from JSON file
            var testDataJson = File.ReadAllText("TestData.json");
            var testData = JsonSerializer.Deserialize<TestData>(testDataJson);

            // Initialize library, books, and locations
            _library = new Library();
            _books = testData.Books;
            _locations = testData.Locations;
        }

        [Fact]
        public void AddBook_ValidBook_Success()
        {
            // Arrange
            var book = _books[0];
            var location = _locations[0];

            // Act
            _library.AddBook(book, location);
            var result = _library.FindBook(book.ISBN);

            // Assert
            Assert.Equal(book, result);
        }

        [Fact]
        public void FindBookLocation_ValidBook_Success()
        {
            // Arrange
            var book = _books[0];
            var location = _locations[0];

            _library.AddBook(book, location);

            // Act
            var result = _library.FindBookLocation(book.ISBN);

            // Assert
            Assert.Equal(location, result);
        }

        [Fact]
        public void FindBookLocation_InvalidBook_ReturnsNull()
        {
            // Arrange
            var book = _books[0];
            var location = _locations[0];

            _library.AddBook(book, location);

            // Act
            var result = _library.FindBookLocation("9876543210");

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void InventoryList_RetrieveFromValidLocation_Success()
        {
            // Arrange
            var book1 = _books[0];
            var book2 = _books[1];
            var location = _locations[0];

            _library.AddBook(book1, location);
            _library.AddBook(book2, location);

            // Act
            var result = _library.InventoryList(location);

            // Assert
            Assert.Equal(new List<Book> { book1, book2 }, result);
        }

        [Fact]
        public void InventoryList_RetrieveFromInvalidLocation_ReturnsNull()
        {
            // Arrange
            var book1 = _books[0];
            var book2 = _books[1];
            var location = _locations[0];

            _library.AddBook(book1, location);
            _library.AddBook(book2, location);

            location = _locations[1];

            // Act
            var result = _library.InventoryList(location);

            // Assert
            Assert.Empty(result);
        }
    }
}
