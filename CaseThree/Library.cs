using CaseThree.Models;

namespace CaseThree
{
    /// <summary>
    /// Class to perform library operations.
    /// </summary>
    public class Library
    {
        private readonly Dictionary<string, Book> _booksByIsbn = new Dictionary<string, Book>();
        private readonly Dictionary<BookLocation, List<Book>> _booksByLocation = new Dictionary<BookLocation, List<Book>>();

        /// <inheritdoc cref="ILibrary.AddBook(Book, BookLocation)"/>
        public void AddBook(Book book, BookLocation location)
        {
            if (!_booksByIsbn.ContainsKey(book.ISBN))
            {
                _booksByIsbn[book.ISBN] = book;
            }

            if (!_booksByLocation.ContainsKey(location))
            {
                _booksByLocation[location] = new List<Book>();
            }

            _booksByLocation[location].Add(book);
        }

        /// <inheritdoc cref="ILibrary.AddBook(string)"/>
        public Book FindBook(string isbn)
        {
            if (_booksByIsbn.TryGetValue(isbn, out Book book))
            {
                return book;
            }

            return null;
        }

        /// <inheritdoc cref="ILibrary.AddBook(string)"/>
        public BookLocation FindBookLocation(string isbn)
        {
            var book = FindBook(isbn);
            if (book == null)
            {
                return null;
            }

            foreach (var kvp in _booksByLocation)
            {
                if (kvp.Value.Contains(book))
                {
                    return kvp.Key;
                }
            }

            return null;
        }

        /// <inheritdoc cref="ILibrary.AddBook(BookLocation)"/>
        public List<Book> InventoryList(BookLocation location)
        {
            if (_booksByLocation.TryGetValue(location, out List<Book> books))
            {
                return books;
            }

            return new List<Book>();
        }
    }
}

